using cafe_pos_system.Models;
using cafe_pos_system.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_pos_system.forms
{
    public partial class UCInvoiceItem : UserControl
    {
        
        private InvoiceDetail invoiceDetail;

        public UCInvoiceItem(InvoiceDetail invoiceDetail)
        {
            InitializeComponent();
            this.invoiceDetail = invoiceDetail;
        }


        private void UCInvoiceItem_Load(object sender, EventArgs e)
        {
            lblCupSize.Text = invoiceDetail.CupSize.ToString();
            lblItem.Text = invoiceDetail.ItemName.ToString();
            lblSugar.Text = invoiceDetail.SugarLevel.ToString()+"%";
            lblIce.Text = invoiceDetail.Ice;
            lblTopping.Text = invoiceDetail.Topping;
            lblQty.Text = invoiceDetail.Qty.ToString();
            lblUnitPrice.Text = invoiceDetail.UnitPrice.ToString("$0.00");
            lblAmount.Text = invoiceDetail.Amount.ToString("$0.00");
        }
    }
}
