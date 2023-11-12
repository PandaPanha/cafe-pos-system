using cafe_pos_system.forms;
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
