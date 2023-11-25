using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_pos_system.services
{
    public static class ValidatorService
    {
        private static string title = "Entry Error";

        public static string Title { get => title; set => title = value; }

        public static bool IsPresentText(TextBox txtB)
        {
            if (txtB.Text == string.Empty)
            {
                MessageBox.Show(txtB.Tag + " is a required field", Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool IsValidPassword(TextBox txtPass, TextBox txtCPass)
        {
            if (txtPass.TextLength < 8 || txtPass.Text != txtCPass.Text)
            {
                MessageBox.Show(txtPass.Tag + " must be at least 8 characters.\n" + "Password and Confirm must be the same.", Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public static bool IsImagePresent(PictureBox picturebx)
        {
            if (picturebx.Image == null)
            {
                MessageBox.Show(picturebx.Tag + " is a required field", Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }

        public static bool IsGenderPresent(RadioButton rdbM,RadioButton rdbF)
        {
            if (!rdbM.Checked && !rdbF.Checked)
            {
                MessageBox.Show("Please select your gender.", Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool IsValidBirthDate(DateTimePicker datepicker)
        {
            DateTime CurrentDate = DateTime.Today;

            if ((CurrentDate.Year - datepicker.Value.Year) <= 17)
            {
                MessageBox.Show("Only 17 or older can be accepted", Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool IsValidPhoneNo(TextBox txtB)
        {

            try
            {
                //try to convert input to decimal to see if it is number
                string phoneNo = txtB.Text;
                phoneNo = phoneNo.Replace(" ", string.Empty);
                txtB.Text = phoneNo;
                Convert.ToInt64(txtB.Text);
                //check to see if input number is longer than 7 digits
                if (txtB.TextLength <= 7)
                {
                    MessageBox.Show("Phone number must be longer than 7 digits.", Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            catch (FormatException)
            {

                MessageBox.Show("Phone number must be all number.", Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public static bool IsValidEmail(TextBox txtB)
        {
            var email = new EmailAddressAttribute();
            if (email.IsValid(txtB.Text) == false)
            {
                MessageBox.Show("Invalid email address.", Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool IsUnique(TextBox txtb, List<string> ExistedItems)
        {
            if (IsPresentText(txtb))
            {
                foreach (string name in ExistedItems)
                {
                    if (name == txtb.Text)
                    {
                        MessageBox.Show(txtb.Text + " is already exist!", Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsUniquePhone(TextBox txtb, List<string> ExistedPhones)
        {
            if (IsValidPhoneNo(txtb))
            {
                txtb.Text = PhoneService.ConvertPhoneToPhoneNoWhiteSpace(txtb.Text);
                foreach (string phone in ExistedPhones)
                {
                    if (phone == txtb.Text)
                    {
                        MessageBox.Show(txtb.Text + " is already being used!", Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsCheckedCheckBox(CheckBox chkbx)
        {
            if (!chkbx.Checked)
            {
                MessageBox.Show("No checkboxs have been checked", Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool IsSelectedComboBox(ComboBox cmb)
        {
            if (cmb.SelectedIndex == -1)
            {
                MessageBox.Show(cmb.Tag + " has not been selected!", Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }

        public static bool IsDecimal(TextBox txtB)
        {
            try
            {
                Convert.ToDecimal(txtB.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("Invalid Input! Make sure " + txtB.Tag + " is number.", Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }
    }
}
