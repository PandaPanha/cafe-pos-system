using cafe_pos_system.Contracts;
using cafe_pos_system.DB;
using cafe_pos_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_pos_system.services
{
    public class InvoiceService : IInvoice
    {
        private readonly InvoiceDB invoiceDB = new InvoiceDB();
        public void DeleteInvoice(int invoiceId)
        {
            invoiceDB.DeleteInvoice(invoiceId);
        }

        public List<Invoice> GetInvoice()
        {
            return invoiceDB.GetInvoice();
        }

        public Invoice GetInvoiceById(int invoiceId)
        {
            return invoiceDB.GetInvoiceById(invoiceId);
        }

        public List<InvoiceDetail> GetInvoiceDetails(int invoiceId)
        {
            return invoiceDB.GetInvoiceDetails(invoiceId);
        }

        public int GetLargestInvoiceId()
        {
            return invoiceDB.GetLargestInvoiceId();
        }

        public void InsertInvoice(Invoice invoice)
        {
            invoiceDB.InsertInvoice(invoice);
            
        }

        public void InsertInvoiceDetail(List<InvoiceDetail> invoiceDetailsList)
        {

            foreach(InvoiceDetail invoiceDetail in invoiceDetailsList)
            {
                invoiceDetail.InvoiceID = GetLargestInvoiceId();
                invoiceDB.InsertInvoiceDetail(invoiceDetail);
            }

        }

        public decimal GetProfit()
        {
            List<Invoice> invoices = GetInvoice();
            decimal profit = 0;
            foreach (Invoice invoice in invoices)
            {
                profit += invoice.GrandTotal;
            }
            return profit;
        }

        public void DeleteInvoiceDetails(int invoiceId)
        {
            List<InvoiceDetail> invoiceDetails = GetInvoiceDetails(invoiceId);
            ItemService itemService = new ItemService();
            List<Item> items = itemService.GetItem();
            foreach (InvoiceDetail invoiceDetail in invoiceDetails)
            {
                foreach(Item item in items)
                {
                    if(item.Id == invoiceDetail.ItemID)
                    {
                        item.SoldQty -= invoiceDetail.Qty;
                        itemService.UpdateItem(item);
                    }
                }
            }
            invoiceDB.DeleteInvoiceDetails(invoiceId);  
        }
    }
}
