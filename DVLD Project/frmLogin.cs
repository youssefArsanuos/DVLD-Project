using BusinLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            this.Close();

        }

        private void ShowMainForm( User U)
        {
            this.Hide();
            Form1 frm = new Form1(this,U);
            frm.ShowDialog();
        }

        private User GenerateUser()
        {
            string UserName = txtUserName.Text.ToString();
            string Password= txtUserPass.Text.ToString();
            int PersonId= User.ReturnUPersonId(txtUserName.Text, txtUserPass.Text);
            byte IsActive = 1;
            int UserId = User.ReturnUserId(PersonId);
            User U =new User(PersonId,UserId,IsActive,UserName,Password);
            
            return U;
        }
        private bool LoginUser()
        {
            int result = User.CheckUser(txtUserName.Text, txtUserPass.Text);

            if (result == 1)
            {
                return true;
            }
            else if (result == 0)
            {
                MessageBox.Show("User is not active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Incorrect User data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnClosePeopleFrm_Click(object sender, EventArgs e)
        {
            if (LoginUser())
            {
                ShowMainForm(GenerateUser());
                txtUserName.Text = "";
                txtUserPass.Text = "";
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
            
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            string UserName = txtUserName.Text.Trim();

            if (string.IsNullOrEmpty(UserName))
            {

                errorProvider1.SetError(txtUserName, "User Name is required!");
                e.Cancel = true;
                return;

            }
            else
            {

                e.Cancel = false;
                errorProvider1.SetError(txtUserName, "");
            }
        }

        private void txtUserPass_Validating(object sender, CancelEventArgs e)
        {
            string Pass = txtUserPass.Text.Trim();

            if (string.IsNullOrEmpty(Pass))
            {

                errorProvider1.SetError(txtUserPass, "Password is required!");
                e.Cancel = true;
                return;

            }
            else
            {

                e.Cancel = false;
                errorProvider1.SetError(txtUserPass, "");
            }
        }
    }
}
