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
        private frmMenu frmMenu;
        public frmDashboard(frmMenu frmMenu)
        {
            InitializeComponent();
            this.frmMenu = frmMenu;
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
    }
}
