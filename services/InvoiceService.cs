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
            // Retrieve invoice details for the given invoice ID
            List<InvoiceDetail> invoiceDetails = GetInvoiceDetails(invoiceId);

            // Create a new instance of ItemService
            ItemService itemService = new ItemService();

            // Retrieve a list of items
            List<Item> items = itemService.GetItem();

            // Iterate through each InvoiceDetail associated with the given invoice ID
            foreach (InvoiceDetail invoiceDetail in invoiceDetails)
            {
                // Iterate through each Item in the list of items
                foreach (Item item in items)
                {
                    // Find the item related to the current InvoiceDetail
                    if (item.Id == invoiceDetail.ItemID)
                    {
                        // Update the sold quantity of the item by subtracting the quantity from the InvoiceDetail
                        item.SoldQty -= invoiceDetail.Qty;

                        // Update the item's information in the database via the ItemService
                        itemService.UpdateItem(item);
                    }
                }
            }

            // Delete the invoice details associated with the given invoice ID from the database
            invoiceDB.DeleteInvoiceDetails(invoiceId);

            /*
            1. **Retrieve Invoice Details**: It fetches the list of invoice details associated with the provided `invoiceId`.
            2. **Item Service Initialization**: Initializes an `ItemService` to interact with items.
            3. **Fetch Items**: Retrieves a list of all items.
            4. **Iterate Through Invoice Details**: For each invoice detail related to the given invoice ID:
               - It loops through the list of items.
               - If the item ID matches the ID in the current invoice detail:
                 - It subtracts the quantity of the invoice detail from the item's `SoldQty`.
                 - Updates the item's information in the database through the `ItemService`.
            5. **Delete Invoice Details**: Finally, it deletes all invoice details associated with the provided `invoiceId` from the database using `invoiceDB.DeleteInvoiceDetails(invoiceId)`.

            This method effectively adjusts the sold quantity of items based on the deleted invoice details and then removes those invoice details from the database.
            */
        }

    }
}
