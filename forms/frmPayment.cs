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
    public partial class frmPayment : Form
    {
        private static decimal grandtotal = 10;
        public frmPayment()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Say Thanks you to the customer");

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txtRecieve_TextChanged(object sender, EventArgs e)
        {
            if(txtRecieve.Text != "")
            {
                
                decimal changedMoney = decimal.Parse(txtRecieve.Text) - decimal.Parse(lblGrandTotal.Text);
                lblChangedMoney.Text = changedMoney.ToString("$0.00");
            }
            else
            {
                lblChangedMoney.Text = "0.00";
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            lblGrandTotal.Text = grandtotal.ToString("0.00");
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if(txtDiscount.Text != "")
            {
                lblGrandTotal.Text = (grandtotal - grandtotal*(decimal.Parse(txtDiscount.Text)/100)).ToString("0.00");
            }
            else
            {
                lblGrandTotal.Text = grandtotal.ToString("0.00");
            }
        }
    }
}
