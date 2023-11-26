using cafe_pos_system.Contracts;
using cafe_pos_system.Models;
using cafe_pos_system.services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_pos_system.DB
{
    public class InvoiceDB: IInvoice
    {
        private SqlConnection con = POSCafeDB.GetConnection();

        public void DeleteInvoice(int id)
        {
            string storeProcedureName = "spDeleteInvoice";
            SqlCommand command = new SqlCommand(storeProcedureName, con);
            command.CommandType = CommandType.StoredProcedure;

            con.Open();

            command.Parameters.AddWithValue("@invoiceId", id);

            command.ExecuteNonQuery();

            con.Close();
        }

        public List<Invoice> GetInvoice()
        {
            List<Invoice> invoices = new List<Invoice>();

            string storedProcedureName = "spGetInvoice";
            SqlCommand command = new SqlCommand(storedProcedureName, con);
            command.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Invoice invoice = new Invoice();
                invoice.Id = int.Parse(reader["invoiceId"].ToString());
                invoice.InvoiceDate = DateTime.Parse(reader["invoiceDate"].ToString()).ToShortDateString();
                invoice.WaitingNo = int.Parse(reader["waitingNo"].ToString());
                invoice.SubTotal = decimal.Parse(reader["subtotal"].ToString());
                invoice.Discount = decimal.Parse(reader["discount"].ToString());
                invoice.GrandTotal = decimal.Parse(reader["grandTotal"].ToString());
                invoice.ReceivedMoney = decimal.Parse(reader["receivedMoney"].ToString());
                invoice.ChangeMoney = decimal.Parse(reader["changeMoney"].ToString());
                invoice.StaffId = int.Parse(reader["staffId"].ToString());
                invoices.Add(invoice);
            }
            reader.Close();
            con.Close();
            return invoices;
        }

        public Invoice GetInvoiceById(int invoiceId)
        {
            Invoice invoice = new Invoice();
            string storedProcedureName = "spGetInvoiceById";
            SqlCommand command = new SqlCommand(storedProcedureName, con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@invoiceid", invoiceId);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                invoice.Id = int.Parse(reader["invoiceId"].ToString());
                invoice.InvoiceDate = DateTime.Parse(reader["invoiceDate"].ToString()).ToShortDateString();
                invoice.WaitingNo = int.Parse(reader["waitingNo"].ToString());
                invoice.SubTotal = decimal.Parse(reader["subtotal"].ToString());
                invoice.Discount = decimal.Parse(reader["discount"].ToString());
                invoice.GrandTotal = decimal.Parse(reader["grandTotal"].ToString());
                invoice.ReceivedMoney = decimal.Parse(reader["receivedMoney"].ToString());
                invoice.ChangeMoney = decimal.Parse(reader["changeMoney"].ToString());
                invoice.StaffId = int.Parse(reader["staffId"].ToString());
            }
            reader.Close();
            con.Close();
            return invoice;
        }

        public List<InvoiceDetail> GetInvoiceDetails(int invoiceId)
        {
            List<InvoiceDetail> invoiceDetailsList = new List<InvoiceDetail>();

            string storedProcedureName = "spGetInvoiceDetails";
            SqlCommand command = new SqlCommand(storedProcedureName, con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@invoiceId", invoiceId);

            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            
            while(reader.Read())
            {
                InvoiceDetail invoiceDetails = new InvoiceDetail();
                invoiceDetails.ItemID = int.Parse(reader["itemId"].ToString());
                invoiceDetails.ItemName = reader["itemName"].ToString();
                invoiceDetails.CupSize = char.Parse(reader["cupSize"].ToString());
                invoiceDetails.SugarLevel = int.Parse(reader["sugarLevel"].ToString());
                invoiceDetails.Ice = reader["ice"].ToString();
                invoiceDetails.Topping = reader["topping"].ToString();
                invoiceDetails.Qty = int.Parse(reader["qty"].ToString());
                invoiceDetails.UnitPrice = decimal.Parse(reader["unitPrice"].ToString());
                invoiceDetails.Amount = decimal.Parse(reader["amount"].ToString());
                invoiceDetailsList.Add(invoiceDetails);
            }
            reader.Close();
            con.Close();
            return invoiceDetailsList;
        }

        public int GetLargestInvoiceId()
        {
            
            string storedProcedureName = "spGetLargestInvoiceId";
            SqlCommand command = new SqlCommand(storedProcedureName, con);
            command.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            int largestInvoiceId = 0;
            if (reader.Read())
            {
                largestInvoiceId = int.Parse(reader["largestInvoiceId"].ToString());
            }
            reader.Close();
            con.Close();
            return largestInvoiceId;
        }

        public void InsertInvoice(Invoice invoice)
        {
            string storeProcedureName = "spInsertInvoice";
            SqlCommand command = new SqlCommand(storeProcedureName, con);
            command.CommandType = CommandType.StoredProcedure;
            con.Open();

            command.Parameters.AddWithValue("@invoiceDate", invoice.InvoiceDate);
            command.Parameters.AddWithValue("@waitingNo", invoice.WaitingNo);
            command.Parameters.AddWithValue("@subTotal", invoice.SubTotal);
            command.Parameters.AddWithValue("@discount", invoice.Discount/100);
            command.Parameters.AddWithValue("@grandTotal", invoice.GrandTotal);
            command.Parameters.AddWithValue("@receivedMoney", invoice.ReceivedMoney);
            command.Parameters.AddWithValue("@changeMoney", invoice.ChangeMoney);
            command.Parameters.AddWithValue("@staffId", invoice.StaffId);

            command.ExecuteNonQuery();

            con.Close();
        }

        public void InsertInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            string storeProcedureName = "spInsertInvoiceDetail";
            SqlCommand command = new SqlCommand(storeProcedureName, con);
            command.CommandType = CommandType.StoredProcedure;
            con.Open();

            command.Parameters.AddWithValue("@invoiceId", invoiceDetail.InvoiceID);
            command.Parameters.AddWithValue("@itemId", invoiceDetail.ItemID);
            command.Parameters.AddWithValue("@itemName", invoiceDetail.ItemName);
            command.Parameters.AddWithValue("@cupSize", invoiceDetail.CupSize);
            command.Parameters.AddWithValue("@sugarLevel", invoiceDetail.SugarLevel);
            command.Parameters.AddWithValue("@ice", invoiceDetail.Ice);
            command.Parameters.AddWithValue("@topping", invoiceDetail.Topping);
            command.Parameters.AddWithValue("@qty", invoiceDetail.Qty);
            command.Parameters.AddWithValue("@unitPrice", invoiceDetail.UnitPrice);
            command.Parameters.AddWithValue("@amount", invoiceDetail.Amount);

            command.ExecuteNonQuery();

            con.Close();
        }
    }
}
