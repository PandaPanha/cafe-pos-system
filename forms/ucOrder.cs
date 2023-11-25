using cafe_pos_system.Models;
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
    public partial class UCOrder : UserControl
    {
        private Item item;
        private InvoiceDetail invoiceDetail;
        private frmMenu frmMenu;

        public UCOrder(Item item, InvoiceDetail invoiceDetail, frmMenu frmMenu)
        {
            InitializeComponent();
            this.item = item;
            this.invoiceDetail = invoiceDetail;
            this.frmMenu = frmMenu;
        }

        public decimal GetAmount()
        {
            return decimal.Parse(txtQty.Text == "" ? "0" : txtQty.Text) * (item.Price + invoiceDetail.CupSizePrice + invoiceDetail.ToppingPrice);
        }
        

        private void OutputOrder()
        {
            lblCupSize.Text = invoiceDetail.CupSize.ToString();
            lblItem.Text = item.Name;
            lblSugar.Text = invoiceDetail.SugarLevel.ToString()+"%";
            lblIce.Text = invoiceDetail.Ice;
            lblTopping.Text = invoiceDetail.Topping;
            lblUnitPrice.Text = (item.Price + invoiceDetail.CupSizePrice + invoiceDetail.ToppingPrice).ToString("$0.00");
            lblAmount.Text = GetAmount().ToString("$0.00");
        }

        private void UCOrder_Load(object sender, EventArgs e)
        {
            ReloadOutput();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            ReloadOutput();
        }

        private void ReloadOutput()
        {
            decimal totalAmount = 0;
            OutputOrder();
            foreach (UCOrder ucOrder in frmMenu.flpOrder.Controls)
            {
                totalAmount += ucOrder.GetAmount();
            }
            frmMenu.SubTotal = totalAmount;
            frmMenu.OutputTotal();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmMenu.flpOrder.Controls.Remove(this);
            frmMenu.SubTotal -= GetAmount();
            frmMenu.OutputTotal();
        }
    }
}
