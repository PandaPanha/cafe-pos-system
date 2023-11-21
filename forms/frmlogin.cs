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
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AccountService accountService = new AccountService();
            Account account = new Account();

            account = accountService.GetUserCredentials(txtUsername.Text, txtPassword.Text);
            OpenFormMenu(1, "Admin");
            /*
            if (account.IsValidAccount())
            {
                OpenFormMenu(account.Id, account.UserType);
            }
            else
            {
                MessageBox.Show("Wrong username and password", "SignIn Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void OpenFormMenu(int accountId, string userType)
        {
            this.Hide();
            var frmMenu = new frmMenu(accountId, userType, this);
            frmMenu.Closed += (s, arg) => this.Close();
            frmMenu.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        
    }
}
