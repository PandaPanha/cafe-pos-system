using cafe_pos_system.Models;
using System;
using System.Windows.Forms;

namespace cafe_pos_system.forms
{
    public partial class UCMenu : UserControl
    {
        private Item item;
        private frmMenu frmMenu;
        public string ItemName { get; set; }
        public UCMenu(Item item, frmMenu frmMenu)
        {
            InitializeComponent();
            this.frmMenu = frmMenu;
            this.item = item;
            ItemName = item.Name;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmSelection(item, frmMenu).ShowDialog();
        }

        private void ucMenu_Load(object sender, EventArgs e)
        {
            lbName.Text = item.Name;
            lbPrice.Text = item.Price.ToString("$0.00");
            pbProduct.Image = item.Picture;

        }
    }
}
