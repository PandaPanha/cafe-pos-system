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
    public partial class frmDashboard : Form
    {
        private InvoiceService invoiceService = new InvoiceService();
        private ItemService itemService = new ItemService();
        private StaffService staffService = new StaffService();
        private Account currentUser;

        private frmMenu frmMenu;
        public frmDashboard(frmMenu frmMenu, Account currentUser)
        {
            InitializeComponent();
            this.frmMenu = frmMenu;
            this.currentUser = currentUser;
        }

        private void pnlStaff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }


        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            new frmCreateUser().ShowDialog();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            new frmItems(frmMenu).ShowDialog();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            new frmStaff().ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            List<Invoice> invoices = invoiceService.GetInvoice();
            foreach(Invoice invoice in invoices)
            {
                UCDashBoardInvoice ucDashBoardInvoice = new UCDashBoardInvoice(invoice);
                flpInvoiceDashBoard.Controls.Add(ucDashBoardInvoice);   
            }

            lblSoldCup.Text = itemService.GetSoldCups().ToString();
            lblProfit.Text = invoiceService.GetProfit().ToString("$0.00");
            lblTotalStaff.Text = staffService.GetTotalStaff().ToString();
            lblPopularDrink.Text = itemService.GetPopularDrink();
            lblCurrentAdmin.Text = currentUser.Username;


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (UCDashBoardInvoice ucDashBoardInvoice in flpInvoiceDashBoard.Controls)
            {
                if (ucDashBoardInvoice.ID.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    ucDashBoardInvoice.Visible = true;
                }
                else
                {
                    ucDashBoardInvoice.Visible = false;
                }
            }
        }
    }
}
