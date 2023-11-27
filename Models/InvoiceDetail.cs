using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_pos_system.Models
{
    public class InvoiceDetail
    {
        public int InvoiceID { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public Char CupSize { get; set; }
        public decimal CupSizePrice { get; set; }
        public int SugarLevel { get; set; }
        public string Ice {  get; set; }
        public string Topping { get; set; }
        public decimal ToppingPrice { get; set; }
        public int Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
    }
}
