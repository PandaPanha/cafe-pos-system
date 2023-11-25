using cafe_pos_system.Contracts;
using cafe_pos_system.Models;
using cafe_pos_system.services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_pos_system.DB
{
    public class ItemDB: IItem
    {
        private SqlConnection con = POSCafeDB.GetConnection();

        public void DeleteItemById(int id)
        {
            string storeProcedureName = "spDeleteItem";
            SqlCommand command = new SqlCommand(storeProcedureName, con);
            command.CommandType = CommandType.StoredProcedure;

            con.Open();

            command.Parameters.AddWithValue("@itemId", id);

            command.ExecuteNonQuery();

            con.Close();
        }

        public Item GetByItemById(int id)
        {
            Item item = new Item();
            string storedProcedureName = "spGetItemById";
            SqlCommand command = new SqlCommand(storedProcedureName, con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@itemId", id);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                item.Name = reader["itemName"].ToString();
                item.Price = decimal.Parse(reader["price"].ToString());
                item.SoldQty = int.Parse(reader["soldQty"].ToString());
                item.Picture = new Bitmap(PictureService.ConvertBinaryToImg((byte[])reader["picture"]));
            }
            reader.Close();
            con.Close();
            return item;
        }

        public List<Item> GetItem()
        {
            List<Item> items = new List<Item>();
            string storedProcedureName = "spGetItem";
            SqlCommand command = new SqlCommand(storedProcedureName, con);
            command.CommandType = CommandType.StoredProcedure;
            
            con.Open();
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                Item item = new Item();
                item.Id = int.Parse(reader["itemId"].ToString());
                item.Name = reader["itemName"].ToString();
                item.Price = decimal.Parse(reader["price"].ToString());
                item.SoldQty = int.Parse(reader["soldQty"].ToString());
                item.Picture = new Bitmap(PictureService.ConvertBinaryToImg((byte[])reader["picture"]));
                items.Add(item);
            }
            reader.Close();
            con.Close();
            return items;
        }

        public void InsertItem(Item item)
        {
            string storeProcedureName = "spInsertItem";
            SqlCommand command = new SqlCommand(storeProcedureName, con);
            command.CommandType = CommandType.StoredProcedure;
            con.Open();

            command.Parameters.AddWithValue("@itemName", item.Name);
            command.Parameters.AddWithValue("@price", item.Price);
            command.Parameters.AddWithValue("@soldQty", item.SoldQty);
            command.Parameters.AddWithValue("@picture", PictureService.ConvertImgToBinary(item.Picture));

            command.ExecuteNonQuery();

            con.Close();
        }

        public void UpdateItem(Item item)
        {
            string storeProcedureName = "spUpdateItem";
            SqlCommand command = new SqlCommand(storeProcedureName, con);
            command.CommandType = CommandType.StoredProcedure;
            con.Open();

            command.Parameters.AddWithValue("@itemId", item.Id);
            command.Parameters.AddWithValue("@itemName", item.Name);
            command.Parameters.AddWithValue("@price", item.Price);
            command.Parameters.AddWithValue("@soldQty", item.SoldQty);
            command.Parameters.AddWithValue("@picture", PictureService.ConvertImgToBinary(item.Picture));

            command.ExecuteNonQuery();

            con.Close();
        }
    }
}
