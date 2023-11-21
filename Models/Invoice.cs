using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_pos_system.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string InvoiceDate { get; set; }
        public int WaitingNo { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal ReceivedMoney {  get; set; }
        public decimal ChangeMoney { get; set; }
        public int StaffId {  get; set; } 
    }
}
