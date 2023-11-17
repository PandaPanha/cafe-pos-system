using cafe_pos_system.DB;
using cafe_pos_system.forms;
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

namespace cafe_pos_system
{
    public partial class frmLogin : Form
    {
        AccountDB accDB = new AccountDB();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*
            AccountService accountService = new AccountService();
            Account account = accountService.GetUserCredentials(txtUsername.Text, txtPassword.Text);
            if (account.IsValidAccount())
            {
                this.Hide();
                var frmMenu = new frmMenu(account.UserType, this);
                frmMenu.Closed += (s, arg) => this.Close();
                frmMenu.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }
            */
            this.Hide();
            var frmMenu = new frmMenu("Admin", this);
            frmMenu.Closed += (s, arg) => this.Close();
            frmMenu.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        
    }
}
