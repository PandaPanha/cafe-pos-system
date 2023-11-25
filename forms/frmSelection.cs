using cafe_pos_system.forms;
using cafe_pos_system.Models;
using cafe_pos_system.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_pos_system
{
    public partial class frmSelection : Form
    {
        private Item item;
        private frmMenu frmMenu;
        private InvoiceDetail invoiceDetail = new InvoiceDetail();
        public frmSelection(Item item, frmMenu frmMenu)
        {
            InitializeComponent();
            this.item = item;
            this.frmMenu = frmMenu;
        }

        private void settleSelection()
        {
            // Extract the topping from the combo box text before the '+' character and assign it to invoiceDetail.Topping
            invoiceDetail.Topping = cmbTopping.Text.Substring(0, cmbTopping.Text.IndexOf("+"));

            // Extract the numeric value from the combo box text for sugar level and assign it to invoiceDetail.SugarLevel
            invoiceDetail.SugarLevel = int.Parse(cmbSugar.Text.Substring(0, cmbSugar.Text.Length - 1));

            // Extract the first character from the combo box text and assign it to invoiceDetail.CupSize as a char
            invoiceDetail.CupSize = char.Parse(cmbCupSize.Text.Substring(0, 1));

            // Set ice type based on the checked state of the 'chkAddIce' checkbox
            invoiceDetail.Ice = chkAddIce.Checked ? "Normal ice" : "No ice";

            // Determine the topping price based on the presence of "None" in the topping combo box
            if (!cmbTopping.Text.Contains("None"))
            {
                invoiceDetail.ToppingPrice = (decimal)0.5;
            }
            else
            {
                invoiceDetail.ToppingPrice = 0;
            }

            // Determine the cup size price based on the selected cup size from the combo box
            if (cmbCupSize.Text.Contains("Medium"))
            {
                invoiceDetail.CupSizePrice = (decimal)0.3;
            }
            else if (cmbCupSize.Text.Contains("Large"))
            {
                invoiceDetail.CupSizePrice = (decimal)0.5;
            }
            else
            {
                invoiceDetail.CupSizePrice = 0;
            }
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                DialogResult result = MessageBox.Show("You have Confirm the order", "Confirm Selection", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    settleSelection();
                    frmMenu.SubTotal += item.Price;
                    frmMenu.flpOrder.Controls.Add(new UCOrder(item, invoiceDetail, frmMenu));
                    frmMenu.OutputTotal();
                    this.Close();
                }
            }
        }

        private Boolean IsValidInput()
        {
            return ValidatorService.IsSelectedComboBox(cmbTopping) && ValidatorService.IsSelectedComboBox(cmbSugar) &&
                   ValidatorService.IsSelectedComboBox(cmbCupSize);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTopping_DropDown(object sender, EventArgs e)
        {
            this.cmbTopping.ForeColor = Color.Black;
        }

        private void cbSuger_DropDown(object sender, EventArgs e)
        {
            this.cmbSugar.ForeColor = Color.Black;
        }

        private void cbCup_DropDown(object sender, EventArgs e)
        {
            this.cmbCupSize.ForeColor = Color.Black;
        }
    }
}
