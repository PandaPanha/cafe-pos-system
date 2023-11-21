using cafe_pos_system.Contracts;
using cafe_pos_system.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            throw new NotImplementedException();
        }

        public Item GetByItemById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Item> GetItem()
        {
            throw new NotImplementedException();
        }

        public void InsertItem(Item item)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
