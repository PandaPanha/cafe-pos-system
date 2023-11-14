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
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pnlStaff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }


        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            new frmCreateUser().Show();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            new frmItems().Show();
        }
    }
}
