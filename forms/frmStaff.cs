using cafe_pos_system.Models;
using cafe_pos_system.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cafe_pos_system.forms
{
    public partial class frmStaff : Form
    {
        private StaffService staffService = new StaffService();
        public frmStaff()
        {
            InitializeComponent();
        }

        private Staff GetInputStaff()
        {
            Staff staff = new Staff();
            if (txtStaffId.Text != string.Empty)
            {
                staff.Id = int.Parse(txtStaffId.Text);
            }
            staff.Name = txtStaffName.Text;
            staff.Gender = rdbMale.Checked ? "Male" : "Female";
            staff.BirthDate = BirthdatePicker.Value.ToString("yyyy-MM-dd");
            staff.Salary = decimal.Parse(txtSalary.Text);
            staff.Position = txtPosition.Text;
            staff.Email = txtEmail.Text;
            staff.Phone = txtPhone.Text;
            staff.Address = txtAddress.Text;
            staff.HiredDate = hiredDatePicker.Value.ToString("yyyy-MM-dd");
            staff.StopWork = chkStop.Checked ? true : false;
            staff.Photo = pbStaffPhoto.Image;
            return staff;
        }

        private void ClearInput()
        {
            txtStaffName.Text = string.Empty;
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
            BirthdatePicker.Value = DateTime.Today;
            txtSalary.Text = string.Empty;
            txtPosition.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
            hiredDatePicker.Value = DateTime.Today;
            chkStop.Checked = false;
            pbStaffPhoto.Image = null;
        }

        private void OutputStaff(Staff staff)
        {
            txtStaffName.Text = staff.Name;
            if (staff.Gender == "Male")
            {
                rdbMale.Checked = true;

            }
            else
            {
                rdbFemale.Checked = true;
            }
            BirthdatePicker.Value = DateTime.Parse(staff.BirthDate);
            txtSalary.Text = staff.Salary.ToString();
            txtPosition.Text = staff.Position.ToString();
            txtEmail.Text = staff.Email.ToString();
            txtPhone.Text = staff.Phone.ToString();
            txtAddress.Text = staff.Address.ToString();
            hiredDatePicker.Value = DateTime.Parse(staff.HiredDate);
            chkStop.Checked = staff.StopWork ? true : false;
            pbStaffPhoto.Image = staff.Photo;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            pbStaffPhoto.Image = PictureService.BrowsePicture();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                Staff staff = GetInputStaff();
                staffService.InsertStaff(staff);
                MessageBox.Show("Successully added a new staff", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayToDGV("");
            }
        }

        private void txtStaffId_TextChanged(object sender, EventArgs e)
        {
            List<Staff> staffs = staffService.GetStaff();
            ClearInput();
            if (txtStaffId.Text == string.Empty)
            {
                EnableInsert(true);
                EnableUpdate(false);
                EnableDelete(false);
            }
            else
            {
                EnableInsert(false);
                try
                {
                    foreach (Staff staff in staffs)
                    {
                        if (staff.Id == int.Parse(txtStaffId.Text))
                        {
                            EnableUpdate(true);
                            EnableDelete(true);
                            OutputStaff(staffService.GetStaffById(int.Parse(txtStaffId.Text)));
                            break;
                        }
                        else
                        {
                            EnableUpdate(false);
                            EnableDelete(false);
                        }
                    }
                }
                catch(FormatException ms)
                {
                    MessageBox.Show(ms.Message, "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this staff", "Delete Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                staffService.DeleteStaffById(int.Parse(txtStaffId.Text));
                MessageBox.Show("Successully deleted");
                ClearInput();
                DisplayToDGV("");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                Staff staff = GetInputStaff();
                staffService.UpdateStaff(staff);
                MessageBox.Show("Successully updated staff", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayToDGV("");
            }

        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            //immediately display all staff to datagridview when this form is opened
            DisplayToDGV("");
        }

        private void DisplayToDGV(string searchString)
        {
            List<Staff> staffList = staffService.GetStaff(); // Call the GetStaff method to retrieve the staff data
            List<Staff> filteredStaff = staffList.Where(staff => staff.Name.ToLower().Contains(searchString.ToLower()) || staff.Phone.Contains(searchString)).ToList();
            dgvStaff.DataSource = filteredStaff;
        }

        private bool IsValidInput()
        {
            return ValidatorService.IsPresentText(txtStaffName) && ValidatorService.IsGenderPresent(rdbMale, rdbFemale) &&
                   ValidatorService.IsValidBirthDate(BirthdatePicker) && ValidatorService.IsDecimal(txtSalary) &&
                   ValidatorService.IsPresentText(txtPosition) && ValidatorService.IsValidEmail(txtEmail) &&
                   ValidatorService.IsValidPhoneNo(txtPhone) && ValidatorService.IsPresentText(txtAddress) &&
                   ValidatorService.IsImagePresent(pbStaffPhoto);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "Search by name or phone...")
            {
                DisplayToDGV(txtSearch.Text);
            }
            else
            {
                DisplayToDGV("");
            }

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search by name or phone...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.SaddleBrown;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search by name or phone...";
                txtSearch.ForeColor = Color.LightGray;
            }
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked area is a cell (not the header or anything else)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Assuming the ID is in the first column (index 0) of the DataGridView
                object idValue = dgvStaff.Rows[e.RowIndex].Cells[0].Value;

                // Display the ID in the TextBox
                txtStaffId.Text = idValue.ToString();
            }
        }

        private void txtStaffId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
    }
}
