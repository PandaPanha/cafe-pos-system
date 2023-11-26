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
    public partial class UCDashBoardInvoice : UserControl
    {
        private Invoice invoice;

        public string ID {  get; set; }
        public UCDashBoardInvoice(Invoice invoice)
        {
            InitializeComponent();
            this.invoice = invoice;
            ID = invoice.Id.ToString();
        }


        

        private void UCDashBoardInvoice_Load(object sender, EventArgs e)
        {
            lblInvoiceID.Text = invoice.Id.ToString();
            lblInvoiceDate.Text = invoice.InvoiceDate.ToString();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            new frmInvoice(invoice.Id).ShowDialog();
        }
    }
}
