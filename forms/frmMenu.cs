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
        private string usertype;
        private frmLogin frmLogin;
        public frmMenu(string usertype, frmLogin frmLogin)
        {
            InitializeComponent();
            this.usertype = usertype;
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
            if (usertype == "Admin")
            {
                btnDashboard.Visible = true;
            }
            else
            {
                btnDashboard.Visible = false;
            }
        }

        
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new frmDashboard().Show();
        }
    }
}
