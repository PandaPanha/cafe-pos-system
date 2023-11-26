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
    public partial class frmInvoice : Form
    {
        private InvoiceService invoiceService = new InvoiceService();
        private StaffService staffService = new StaffService();
        private Invoice invoice = new Invoice();
        private List<InvoiceDetail> invoiceDetailsList;
        public frmInvoice(int invoiceId)
        {
            InitializeComponent();
            this.invoice.Id = invoiceId;
        }

        private void OutputInvoice()
        {
            invoice = invoiceService.GetInvoiceById(invoice.Id);
            lblInvoiceId.Text = invoice.Id.ToString();
            lblName.Text = staffService.GetStaffName(invoice.StaffId);
            lblinvoiceDate.Text = invoice.InvoiceDate;
            lblWaitingNo.Text = invoice.WaitingNo.ToString();
            lblSubTotal.Text = invoice.SubTotal.ToString("$0.00");
            lblDiscount.Text = invoice.Discount.ToString() + "%";
            lblGrandTotal.Text = invoice.GrandTotal.ToString("$0.00");
            lblRecieve.Text = invoice.ReceivedMoney.ToString("$0.00");
            lblChangeMoney.Text = invoice.ChangeMoney.ToString("$0.00");

        }

        private void OutputDetails()
        {
            invoiceDetailsList = invoiceService.GetInvoiceDetails(invoice.Id);
            foreach (InvoiceDetail invoiceDetail in invoiceDetailsList)
            {
                UCInvoiceItem ucInvoiceItem = new UCInvoiceItem(invoiceDetail);
                flpInvoice.Controls.Add(ucInvoiceItem);
            }
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            OutputInvoice();
            OutputDetails();
        }
    }
}
