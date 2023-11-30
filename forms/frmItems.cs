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

namespace cafe_pos_system.forms
{
    public partial class frmItems : Form
    {
        private ItemService itemService = new ItemService();
        private frmMenu frmMenu;
        public frmItems(frmMenu frmMenu)
        {
            InitializeComponent();
            this.frmMenu = frmMenu;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            pbItem.Image = PictureService.BrowsePicture();
        }

        private Item GetInputItem()
        {
            Item item = new Item();
            if(txtItemID.Text != string.Empty) { item.Id = int.Parse(txtItemID.Text); }
            item.Name = txtItemName.Text;
            item.Price = Decimal.Parse(txtPrice.Text);
            item.SoldQty = int.Parse(txtSoldQty.Text);
            item.Picture = pbItem.Image;
            return item;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                itemService.InsertItem(GetInputItem());
                MessageBox.Show("New Item has been added!", "Insert Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayToDGV("");
                frmMenu.ReloadMenu();
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to update this item?", "Update Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                MessageBox.Show("Update is completed!", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                itemService.UpdateItem(GetInputItem());
                DisplayToDGV("");
                frmMenu.ReloadMenu();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(GetInputItem().Name +" has been deleted", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                itemService.DeleteItemById(int.Parse(txtItemID.Text));
                ClearInput();
                DisplayToDGV("");
                frmMenu.ReloadMenu();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemID.Text = string.Empty;
            ClearInput();
        }

        private Boolean IsValidInput()
        {
            return ValidatorService.IsPresentText(txtItemName) && ValidatorService.IsDecimal(txtPrice) &&
                   ValidatorService.IsImagePresent(pbItem);
        }

        

        private void DisplayToDGV(string searchString)
        {
            List<Item> items = itemService.GetItem();
            //Exclude picture from item and display only where item name is similar to search string to datagridview
            var filteredItems = items
                .Select(item => new
                {
                    item.Id,
                    item.Name,
                    item.Price,
                    item.SoldQty
                })
                .Where(item => item.Name.ToLower().Contains(searchString.ToLower()))
                .ToList();

            //display filtered items to datagridview 
            dgvItem.DataSource = filteredItems;

        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            DisplayToDGV("");
        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked area is a cell (not the header or anything else)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Assuming the ID is in the first column (index 0) of the DataGridView
                object idValue = dgvItem.Rows[e.RowIndex].Cells[0].Value;

                // Display the ID in the TextBox
                txtItemID.Text = idValue.ToString();
            }
        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {
            // Retrieve a list of items using the itemService
            List<Item> items = itemService.GetItem();

            // Clear the input controls or fields (assuming there's a method named ClearInput)
            ClearInput();

            if (txtItemID.Text == string.Empty)
            {
                // If the text in txtItemID is empty, enable insertion and disable update and delete
                EnableInsert(true);
                EnableUpdate(false);
                EnableDelete(false);
            }
            else
            {
                // If there's text in txtItemID
                EnableInsert(false);
                try
                {
                    // Loop through each item in the items list
                    foreach (Item item in items)
                    {
                        if (item.Id == int.Parse(txtItemID.Text))
                        {
                            // If the ID of the item matches the text in txtItemID, enable update and delete
                            EnableUpdate(true);
                            EnableDelete(true);

                            // Output the details of the item (assuming this method displays item details)
                            OutputItem(itemService.GetByItemById(int.Parse(txtItemID.Text)));
                            break;
                        }
                        else
                        {
                            // If no matching ID is found, disable update and delete
                            EnableUpdate(false);
                            EnableDelete(false);
                        }
                    }
                }
                catch (Exception ms)
                {
                    // Catch and display any exception that occurs during parsing
                    MessageBox.Show(ms.Message, "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            /*
                1. **Text Change Event**: This method (`txtItemID_TextChanged`) is triggered when the text in the `txtItemID` textbox changes.
                2. **Item Retrieval**: It retrieves a list of items using the `itemService`.
                3. **Clear Input**: Clears the input controls or fields.
                4. **Handling Empty Text**: If `txtItemID` is empty, it enables insertion and disables update and delete functionalities.
                5. **Non-empty Text Handling**: If `txtItemID` has text:
                    - Disables insertion.
                    - Tries to parse the text as an integer within a try-catch block.
                    - Loops through each item in the retrieved item list.
                    - If a matching ID is found, it enables update and delete functionalities and outputs details of the item.
                    - If no matching ID is found, it disables update and delete functionalities.
                6. **Exception Handling**: Catches and displays any exceptions that occur during the parsing of the text as an integer. 
            */
        }


        private void OutputItem(Item item)
        {
            txtItemName.Text = item.Name;
            txtPrice.Text = item.Price.ToString();
            txtSoldQty.Text = item.SoldQty.ToString();
            pbItem.Image = item.Picture;
        }

        private void ClearInput()
        {
            txtItemName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtSoldQty.Text = string.Empty;
            pbItem.Image = null;
        }

        private void EnableInsert(Boolean status)
        {
            btnInsert.Enabled = status;
            btnInsert.BackColor = btnInsert.Enabled ? Color.FromArgb(238, 230, 216) : Color.LightGray;
        }

        private void EnableUpdate(Boolean status)
        {
            btnUpdate.Enabled = status;
            btnUpdate.BackColor = btnUpdate.Enabled ? Color.FromArgb(238, 230, 216) : Color.LightGray;
        }

        private void EnableDelete(Boolean status)
        {
            btnDelete.Enabled = status;
            btnDelete.BackColor = btnDelete.Enabled ? Color.FromArgb(210, 4, 45) : Color.LightGray;
        }

        private void txtItemID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSoldQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "Search by name...")
            {
                DisplayToDGV(txtSearch.Text);
            }
            else
            {
                DisplayToDGV("");
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search by item name...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.SaddleBrown;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search by item name...";
                txtSearch.ForeColor = Color.Silver;
            }
        }
    }
}
