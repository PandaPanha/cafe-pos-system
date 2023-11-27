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
    public partial class UCDashBoardInvoice : UserControl
    {
        private Invoice invoice;
        private readonly InvoiceService invoiceService = new InvoiceService();
        private frmDashboard frmDashboard;
        public string ID {  get; set; }
        public UCDashBoardInvoice(Invoice invoice, frmDashboard frmDashboard)
        {
            InitializeComponent();
            this.invoice = invoice;
            ID = invoice.Id.ToString();
            this.frmDashboard = frmDashboard;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this invoice?", "Delete Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //in order to delete an invoice, it's better to delete invoice details first to avoid foreign key error
                invoiceService.DeleteInvoiceDetails(invoice.Id);
                invoiceService.DeleteInvoice(invoice.Id);
                frmDashboard.ReloadDashboard();
            }
        }
    }
}
