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
    public partial class frmMenu : Form
    {
        private Account CurrentUser = new Account();
        private readonly InvoiceService invoiceService = new InvoiceService();
        private readonly ItemService itemService = new ItemService();
        private frmLogin frmLogin;
        private List<Item> items;
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal ChangeMoney { get; set; }
        private int WaitingNo { get; set; }

        public void OutputTotal()
        {
            try
            {
                // Parse the discount value from the text box input. If the text box is empty, default the discount to 0.
                Discount = decimal.Parse(txtDiscount.Text == "" ? "0" : txtDiscount.Text);

                // Calculate the GrandTotal by subtracting the discount from the SubTotal.
                // The discount is represented as a percentage of the SubTotal.
                GrandTotal = SubTotal - (SubTotal * (Discount / 100));

                // Parse the received amount from the text box input. If empty, default the amount to 0.
                decimal receivedAmount = decimal.Parse(txtRecieve.Text == "" ? "0" : txtRecieve.Text);

                // Calculate the ChangeMoney by subtracting the GrandTotal from the received amount.
                ChangeMoney = receivedAmount - GrandTotal;

                lblGrandTotal.Text = GrandTotal.ToString("$0.00");
                lblSubtotal.Text = SubTotal.ToString("$0.00");
                lblChangedMoney.Text = ChangeMoney.ToString("$0.00");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+"\nPlease input digits and correct punctuation", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public frmMenu(Account account, frmLogin frmLogin)
        {
            InitializeComponent();
            this.CurrentUser = account;
            this.frmLogin = frmLogin;
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                this.Hide();
                var frmLogin = new frmLogin();
                frmLogin.Closed += (s, args) => this.Close();
                frmLogin.Show();
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (CurrentUser.UserType == "Admin")
            {
                btnDashboard.Visible = true;
            }
            else
            {
                btnDashboard.Visible = false;
            }
            WaitingNo = 1;
            ReloadMenu();
        }

        public void ReloadMenu()
        {
            flpMenu.Controls.Clear();
            items = new ItemService().GetItem();
            foreach (Item item in items)
            {
                UCMenu ucMenu = new UCMenu(item, this);
                flpMenu.Controls.Add(ucMenu);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new frmDashboard(this, CurrentUser).ShowDialog();
        }


        private void ClearTransaction()
        {
            lblGrandTotal.Text = "$0.00";
            lblSubtotal.Text = "$0.00";
            lblChangedMoney.Text = "$0.00";
            txtDiscount.Text = "0";
            txtRecieve.Text = "0";
            SubTotal = 0;
            Discount = 0;
            ChangeMoney = 0;
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            OutputTotal();
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            if( txtDiscount.Text == "")
            {
                txtDiscount.Text = "0";
            }
        }

        private void txtRecieve_TextChanged(object sender, EventArgs e)
        {
            
            OutputTotal();
        }

        private void txtRecieve_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private Invoice GetInvoice()
        {
            Invoice invoice = new Invoice();
            invoice.InvoiceDate = DateTime.UtcNow.ToShortDateString();
            invoice.StaffId = CurrentUser.StaffId;
            invoice.WaitingNo = WaitingNo;
            invoice.SubTotal = SubTotal;
            invoice.Discount = Discount;
            invoice.GrandTotal = GrandTotal;
            invoice.ReceivedMoney = decimal.Parse(txtRecieve.Text);
            invoice.ChangeMoney = ChangeMoney;
            return invoice;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if(flpOrder.Controls.Count <= 0)
            {
                MessageBox.Show("There is no order!", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtRecieve.Text == "0")
            {
                MessageBox.Show("Please enter receive value!", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(decimal.Parse(txtRecieve.Text) < GrandTotal)
            {
                MessageBox.Show("Receive value can't be less than Grand Total!", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Confirm Check out?", "Check Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                List<InvoiceDetail> invoiceDetailsList = new List<InvoiceDetail>();
                foreach (UCOrder ucOrder in flpOrder.Controls)
                {
                    invoiceDetailsList.Add(ucOrder.GetInvoiceDetail());

                    itemService.UpdateItem(ucOrder.GetItemSoldQty());
                }
                invoiceService.InsertInvoice(GetInvoice());
                invoiceService.InsertInvoiceDetail(invoiceDetailsList);
                WaitingNo++;
                ClearTransaction();
                flpOrder.Controls.Clear();
                new frmInvoice(invoiceService.GetLargestInvoiceId()).ShowDialog();
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach(UCMenu ucmenu in flpMenu.Controls)
            {
                if (ucmenu.ItemName.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    ucmenu.Visible = true;
                }
                else
                {
                    ucmenu.Visible = false;
                }
            }
        }
    }
}
