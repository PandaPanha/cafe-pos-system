using System;
using System.Windows.Forms;

namespace cafe_pos_system.forms
{
    public partial class ucMenu : UserControl
    {
        public ucMenu()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmSelection().ShowDialog();
        }
    }
}
