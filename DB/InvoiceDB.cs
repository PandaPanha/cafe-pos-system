using cafe_pos_system.Contracts;
using cafe_pos_system.Models;
using cafe_pos_system.services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            throw new NotImplementedException();
        }

        public Invoice GetInvoiceById()
        {
            throw new NotImplementedException();
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
            command.Parameters.AddWithValue("@discount", invoice.Discount);
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
