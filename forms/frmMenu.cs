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
        private frmLogin frmLogin;
        private List<Item> items = new ItemService().GetItem();

        public frmMenu(int accountId, string usertype, frmLogin frmLogin)
        {
            InitializeComponent();
            this.CurrentUser.Id = accountId;
            this.CurrentUser.UserType = usertype;
            this.frmLogin = frmLogin;
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmLogin = new frmLogin();
            frmLogin.Closed += (s, args) => this.Close();
            frmLogin.Show();
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
            foreach(Item item in items)
            {
                UCMenu ucMenu = new UCMenu(item);
                flpMenu.Controls.Add(ucMenu);
            }


        }

        
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new frmDashboard().ShowDialog();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            new frmPayment().Show();
        }
    }
}
