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
    public partial class frmCreateUser : Form
    {
        private readonly AccountService accountService = new AccountService();
        private readonly StaffService staffService = new StaffService();
        public frmCreateUser()
        {
            InitializeComponent();
            
        }

        private Account GetInputUserAccount()
        {
            Account account = new Account();
            account.Username = txtUsername.Text;
            account.Password = txtPassword.Text;
            account.UserType = cmbUserType.Text;
            account.StaffId = int.Parse(txtStaffID.Text);
            return account;
        }


        

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                Account account = GetInputUserAccount();
                accountService.InsertAccount(account);
                MessageBox.Show("A new user account has been created!", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInput();
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Account account = GetInputUserAccount();
            if (IsValidInput())
            {
                accountService.UpdateAccount(account);
                MessageBox.Show("Account has been updated!", "Update Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Boolean IsValidInput()
        {
            return ValidatorService.IsPresentText(txtUsername) && ValidatorService.IsPresentText(txtPassword) &&
                   ValidatorService.IsPresentText(txtConfPassword) && ValidatorService.IsSelectedComboBox(cmbUserType) &&
                   ValidatorService.IsValidPassword(txtPassword, txtConfPassword);
        }

        private void OutputStaff(Account account, Staff staff)
        {
            lblId.Text = staff.Id.ToString();
            lblBirthDate.Text = DateTime.Parse(staff.BirthDate).ToShortDateString();
            lblPhone.Text = staff.Phone;
            lblHiredDate.Text = DateTime.Parse(staff.HiredDate).ToShortDateString();
            lblStatus.Text = staff.StopWork ? "Stop Working" : "Working";
            phbStaff.Image = staff.Photo;
            lblName.Text = staff.Name;
            lblEmail.Text = staff.Email;
        }

        private void ClearInput()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfPassword.Text = string.Empty;
            cmbUserType.SelectedIndex = -1;
        }

        private void ClearOutput()
        {
            lblId.Text = "0000";
            lblBirthDate.Text = "MM/DD/YYYY";
            lblPhone.Text = "XXX XXX XXX";
            lblHiredDate.Text = "MM/DD/YYYY";
            lblStatus.Text = "Unknown";
            phbStaff.Image = null;
            lblName.Text = "Name";
            lblEmail.Text = "myemail@gmail.com";
        }

        private void OutputAccount(Account account)
        {
            txtUsername.Text = account.Username;
            txtPassword.Text = account.Password;
            txtConfPassword.Text = account.Password;
            cmbUserType.Text = account.UserType;
        }

        private Account GetStaffAccount()
        {
            List<Account> accounts = accountService.GetAllAccount();
            foreach(Account account in accounts)
            {
                if(account.StaffId == int.Parse(txtStaffID.Text))
                {
                    OutputAccount(account);
                    EnableButtonCreate(false);
                    return account;
                }
            }
            return null;
        }

        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {
            ClearOutput();
            ClearInput();
            if(txtStaffID.Text == string.Empty)
            {
                EnableInput(false);
                EnableButtonCreate(false);
                EnableButtonUpdate(false);
            }
            else
            {
                List<Staff> staffs = staffService.GetStaff();
                
                foreach (Staff staff in staffs)
                {
                    if(staff.Id == int.Parse(txtStaffID.Text))
                    {
                        if (accountService.HasStaffAccount(int.Parse(txtStaffID.Text)))
                        {

                            EnableInput(true);
                            EnableButtonCreate(false);
                            EnableButtonUpdate(true);
                            OutputStaff(GetStaffAccount(), staff);
                        }
                        else if (!accountService.HasStaffAccount(int.Parse(txtStaffID.Text)))
                        {

                            EnableInput(true);
                            EnableButtonCreate(true);
                            EnableButtonUpdate(false);
                            OutputStaff(GetStaffAccount(), staff);
                        }
                        break;
                    }
                    else
                    {
                        EnableInput(false);
                        EnableButtonCreate(false);
                        EnableButtonUpdate(false);
                    }
                }
            }
            
        }

        // Accept only digits in textbox StaffId
        private void txtStaffID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EnableInput(Boolean status)
        {
            txtUsername.Enabled = status;
            txtPassword.Enabled = status;
            txtConfPassword.Enabled = status;
            cmbUserType.Enabled = status;
        }

        private void EnableButtonCreate(Boolean isEnable)
        {
            if (isEnable)
            {
                btnCreate.Enabled = true;
                btnCreate.BackColor = Color.FromArgb(238, 230, 216);
            }
            else
            {
                btnCreate.Enabled = false;
                btnCreate.BackColor = Color.LightGray;
            }
        }

        private void EnableButtonUpdate(Boolean isEnable)
        {
            if (isEnable)
            {
                btnUpdate.Enabled = true;
                btnUpdate.BackColor = Color.FromArgb(238, 230, 216);
            }
            else
            {
                btnUpdate.Enabled = false;
                btnUpdate.BackColor = Color.LightGray;
            }
        }

        
    }

}
