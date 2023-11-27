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
            Account account = accountService.GetUserCredentials(txtUsername.Text, txtPassword.Text);
            if (account == null) return;
            if (account.IsValidAccount())
            {
                OpenFormMenu(account);
            }
            else
            {
                MessageBox.Show("Wrong username and password", "SignIn Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void OpenFormMenu(Account acc)
        {
            this.Hide();
            var frmMenu = new frmMenu(acc, this);
            frmMenu.Closed += (s, arg) => this.Close();
            frmMenu.Show();
            /*
                1. **Hide Current Form**: `this.Hide()` hides the current form where this method is being called from.
                2. **Create New Form**: It instantiates a new form named `frmMenu` while passing an `Account` object (`acc`) 
                    and a reference to the current form (`this`) as parameters.
                3. **Close Event Handler**: Attaches an event handler to the `Closed` event of the `frmMenu` form. 
                    When `frmMenu` is closed, it triggers an action that closes the current form (`this`).
                4. **Show New Form**: Displays the `frmMenu` form using `frmMenu.Show()`.

                Overall, this method facilitates transitioning from the current form to a new form (menu form in this case) 
                while ensuring that when the new form is closed, the current form is closed as well.
            */
        }
    }
}
