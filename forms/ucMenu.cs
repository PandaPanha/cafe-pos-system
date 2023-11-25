using cafe_pos_system.Models;
using System;
using System.Windows.Forms;

namespace cafe_pos_system.forms
{
    public partial class UCMenu : UserControl
    {
        Item item;
        public UCMenu(Item item)
        {
            InitializeComponent();
            this.item = item;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmSelection().ShowDialog();
        }

        private void ucMenu_Load(object sender, EventArgs e)
        {
            lbName.Text = item.Name;
            lbPrice.Text = item.Price.ToString("$0.00");
            pbProduct.Image = item.Picture;

        }
    }
}
