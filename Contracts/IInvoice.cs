using cafe_pos_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_pos_system.Contracts
{
    public interface IInvoice
    {
        List<Invoice> GetInvoice();
        Invoice GetInvoiceById(int invoiceId);
        void InsertInvoice(Invoice invoice);
        List<InvoiceDetail> GetInvoiceDetails(int invoiceId);
        void DeleteInvoice(int invoiceId);
        int GetLargestInvoiceId();
    }
}
