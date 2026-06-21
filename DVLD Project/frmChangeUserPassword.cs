using BusinLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmChangeUserPassword : Form
    {

        public event Action EditUser;
        private User user;

        
        public frmChangeUserPassword(User U)
        {
            InitializeComponent();
            user = U;
            InitializeUserCard();
        }

        private void InitializeUserCard()
        {
            ctrUserrCard1.PersonId = user.PersonId;
            ctrUserrCard1.UserId = user.UserId;
            ctrUserrCard1.UserName = user.UserName;
            ctrUserrCard1.IsActive = user.IsActive;
            ctrUserrCard1.Mode = 3;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChangeUserPassword_Load(object sender, EventArgs e)
        {

        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPCClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            string TName = txtNewPassword.Text.Trim();

            if (string.IsNullOrEmpty(TName))
            {

                errorProvider1.SetError(txtNewPassword, "Password is required!");
                e.Cancel = true;
                return;

            }
            else
            {

                e.Cancel = false;
                errorProvider1.SetError(txtNewPassword, "");
            }
        }

        private void txtConNewPassword_Validating(object sender, CancelEventArgs e)
        {
            string TName = txtConNewPassword.Text.Trim();

            if (string.IsNullOrEmpty(TName))
            {

                errorProvider1.SetError(txtConNewPassword, "Password is required!");
                e.Cancel = true;
                return;

            }
            else
            {

                e.Cancel = false;
                errorProvider1.SetError(txtConNewPassword, "");
            }

            if (txtNewPassword.Text != txtConNewPassword.Text)
            {
                errorProvider1.SetError(txtConNewPassword, "Passwords do not match!");
                //e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtConNewPassword, "");
            }
        }
        
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtUserOldPass.Text)|| string.IsNullOrWhiteSpace(txtNewPassword.Text)|| string.IsNullOrWhiteSpace(txtConNewPassword.Text))
            {

                MessageBox.Show("Enter all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtUserOldPass.Text.ToString() != user.Password)
            {
                MessageBox.Show("Incorrect Old Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNewPassword.Text.ToString() != txtConNewPassword.Text.ToString())
            {
                MessageBox.Show("Confirm password doesn't match with new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void ChangePassword()
        {
            if (ValidateInput())
            {
                User user2 = user;
                user2.Password = txtNewPassword.Text.ToString();
                if (User.EditUserPassword(user2))
                {
                    user.Password=user2.Password;
                    MessageBox.Show("User's password  edited successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    EditUser?.Invoke();
                }
                else
                {
                    MessageBox.Show($"User's password doesn't edited try again ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
           
        }
        private void btnPCSave_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }

        private void txtUserOldPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserOldPass_Validating(object sender, CancelEventArgs e)
        {
            string TName = txtUserOldPass.Text.Trim();

            if (string.IsNullOrEmpty(TName))
            {

                errorProvider1.SetError(txtUserOldPass, "Old password is required!");
                e.Cancel = true;
                return;

            }
            else
            {

                e.Cancel = false;
                errorProvider1.SetError(txtUserOldPass, "");
            }
        }
    }
}
