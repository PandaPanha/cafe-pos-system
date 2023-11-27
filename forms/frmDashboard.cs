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
            new frmStaff(this).ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ReloadDashboard()
        {
            // Retrieve a list of invoices using the InvoiceService
            List<Invoice> invoices = invoiceService.GetInvoice();

            // Clear the controls within the flpInvoiceDashBoard FlowLayoutPanel
            flpInvoiceDashBoard.Controls.Clear();

            // Iterate through each Invoice in the 'invoices' list
            foreach (Invoice invoice in invoices)
            {
                // Create a new instance of UCDashBoardInvoice, passing the current 'invoice' and 'this' (current context)
                UCDashBoardInvoice ucDashBoardInvoice = new UCDashBoardInvoice(invoice, this);

                // Add the created UCDashBoardInvoice control to the flpInvoiceDashBoard FlowLayoutPanel
                flpInvoiceDashBoard.Controls.Add(ucDashBoardInvoice);
            }

            // Update the labels with various statistics or data
            // Set the text of lblSoldCup to the number of sold cups retrieved from itemService
            lblSoldCup.Text = itemService.GetSoldCups().ToString();

            // Set the text of lblProfit to the profit retrieved from invoiceService, formatted as a currency string
            lblProfit.Text = invoiceService.GetProfit().ToString("$0.00");

            // Set the text of lblTotalStaff to the total number of staff retrieved from staffService
            lblTotalStaff.Text = staffService.GetTotalStaff().ToString();

            // Set the text of lblPopularDrink to the name of the popular drink retrieved from itemService
            lblPopularDrink.Text = itemService.GetPopularDrink();

            // Set the text of lblCurrentAdmin to the username of the current user
            lblCurrentAdmin.Text = currentUser.Username;

            /*
                1. Retrieves a list of invoices using invoiceService.GetInvoice().

                2. Clears the controls within flpInvoiceDashBoard.

                3. Iterates through each invoice in the retrieved list, creating UCDashBoardInvoice controls and adding them to the flpInvoiceDashBoard.

                4. Updates various labels (lblSoldCup, lblProfit, lblTotalStaff, lblPopularDrink, lblCurrentAdmin) with specific data 
                fetched from services (itemService, invoiceService, staffService) and the current user (currentUser).
            */
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            ReloadDashboard();
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Iterate through each control of type UCDashBoardInvoice within flpInvoiceDashBoard's Controls collection
            foreach (UCDashBoardInvoice ucDashBoardInvoice in flpInvoiceDashBoard.Controls)
            {
                // Check if the ID of the UCDashBoardInvoice (converted to lowercase) contains the search text (also converted to lowercase)
                if (ucDashBoardInvoice.ID.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    // If the search text is found in the ID, set the control's visibility to true
                    ucDashBoardInvoice.Visible = true;
                }
                else
                {
                    // If the search text is not found in the ID, set the control's visibility to false
                    ucDashBoardInvoice.Visible = false;
                }
            }
            /*
            1. Iteration: It loops through each control contained within `flpInvoiceDashBoard`.
            2. Visibility: For controls of type `UCDashBoardInvoice`, it checks if the ID 
            (after converting both the ID and the search text to lowercase) contains the text entered in the `txtSearch` textbox.
            3. Visibility Adjustment: If the search text is found within the ID, it sets the control's visibility to `true`,
            making it visible. Otherwise, it hides the control by setting its visibility to `false`.

            This code essentially filters the visibility of `UCDashBoardInvoice` controls within `flpInvoiceDashBoard` based on 
            whether their ID contains the text entered in the `txtSearch` textbox. If the text matches part of the ID, 
            the corresponding control is shown; otherwise, it's hidden. 
            */
        }
    }
}
