using BusinLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmAddOrEditUser : Form
    {
        public event Action UserAdded;

        private int _mode;
        private User user;
        public frmAddOrEditUser(int mode)
        {
            InitializeComponent();
            _mode = mode;
            
        }
        public frmAddOrEditUser(int mode,User U)
        {
            InitializeComponent();
            _mode = mode;
            user = U;

        }
        private void ctrPerson1_Load(object sender, EventArgs e)
        {

        }

        private void PrepareSearchBar()
        {
            cmbUSearchPeoples.Items.Add("PersonId");
            cmbUSearchPeoples.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUSearchPeoples.SelectedItem = "PersonId";
            cmbUSearchPeoples.Enabled = false;


        }

        private void IntializeTitle()
        {
            if (_mode == 1)
            {
                lblMainTitle.Text = "Add User";

            }
            else if (_mode == 2)
            {
                lblMainTitle.Text = "Edit User";
                groupBox1.Enabled = false;
            }

           
        }

        private void AddUserMode()
        {
            ctrPerson1.CardInPersonInfo();
            PrepareSearchBar();
        }
        private void EditUserMode()
        {
            ctrPerson1.PersonId = user.PersonId;
            ctrPerson1.Mode = 3;

        }
        private void ApplyMode()
        {
            if (_mode == 1)
            {
                AddUserMode();
            }
            else if(_mode == 2)
            {
                EditUserMode();
            }
        }
        private void AddUser_Load(object sender, EventArgs e)
        {
            IntializeTitle();
            ApplyMode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_mode == 1)
            {
                if (string.IsNullOrWhiteSpace(txtUSearchPerson.Text))
                {

                    MessageBox.Show("Enter Person Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //check if person exist in the system
                if (!People.CheckIfPersonExist(txtUSearchPerson.Text))
                {
                    MessageBox.Show("This Person doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //check if person is User in the system
                if (People.CheckIfPersonIsUser(txtUSearchPerson.Text.ToString()))
                {
                    MessageBox.Show("This Person is already an User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tabControl1.SelectedIndex = 1;
            }
            else if (_mode == 2) {
                tabControl1.SelectedIndex = 1;
            }

        }

        private void btnPCClose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void ShowAddForm()
        {
            AddandDelete_Person frm = new AddandDelete_Person(1);
            //frm.MyPersonControl.PersonAdded += _RefreshHistory;
            frm.ShowDialog();


        }
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            ShowAddForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            string TName = txtUserName.Text.Trim();

            if (string.IsNullOrEmpty(TName))
            {

                errorProvider1.SetError(txtUserName, "Third Name is required!");
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
            string TName = txtUserPass.Text.Trim();

            if (string.IsNullOrEmpty(TName))
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

        private void txtUserCPass_TextChanged(object sender, EventArgs e)
        {
            if (txtUserCPass.Text != txtUserPass.Text)
            {
                errorProvider1.SetError(txtUserCPass, "Passwords do not match!");
            }
            else
            {
                errorProvider1.SetError(txtUserCPass, "");
            }

        }

        private void txtUserCPass_Validating(object sender, CancelEventArgs e)
        {
            string TName = txtUserCPass.Text.Trim();

            if (string.IsNullOrEmpty(TName))
            {

                errorProvider1.SetError(txtUserCPass, "Third Name is required!");
                e.Cancel = true;
                return;

            }
            else
            {

                e.Cancel = false;
                errorProvider1.SetError(txtUserCPass, "");
            }

            if (txtUserCPass.Text != txtUserPass.Text)
            {
                errorProvider1.SetError(txtUserCPass, "Passwords do not match!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtUserCPass, "");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void SearchPerson()
        {
            if (!string.IsNullOrWhiteSpace(txtUSearchPerson.Text))
            {
                int id = Convert.ToInt32(txtUSearchPerson.Text);
                ctrPerson1.PersonId = id;
                ctrPerson1.Mode = 3;
            }
            else
            {
                MessageBox.Show("Enter Person Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            SearchPerson();
        }

        private void txtUSearchPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
       
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private bool CheckValdation()
        {
            if (_mode == 1)
            {
                //check if search bar is empty
                if (string.IsNullOrWhiteSpace(txtUSearchPerson.Text))
                {

                    MessageBox.Show("Enter Person Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //check if person exist in the system
                if (!People.CheckIfPersonExist(txtUSearchPerson.Text))
                {
                    MessageBox.Show("This Person doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //check if person is User in the system
                if (People.CheckIfPersonIsUser(txtUSearchPerson.Text.ToString()))
                {
                    MessageBox.Show("This Person is already an User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // check user fields
                if (txtUserName.Text == "" || txtUserPass.Text == "" || txtUserCPass.Text == "")
                {
                    MessageBox.Show("Enter all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //check confirm password
                if (txtUserPass.Text != txtUserCPass.Text)
                {
                    MessageBox.Show("Confirm password doesn't match with password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (_mode == 2) {
                // check user fields
                if (txtUserName.Text == "" || txtUserPass.Text == "" || txtUserCPass.Text == "")
                {
                    MessageBox.Show("Enter all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //check confirm password
                if (txtUserPass.Text != txtUserCPass.Text)
                {
                    MessageBox.Show("Confirm password doesn't match with password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
            }
            return true;
        }

        private void AddUser()
        {
            int PersonId = Convert.ToInt32(txtUSearchPerson.Text);
            string UserName=txtUserName.Text.ToString();
            string Password=txtUserPass.Text.ToString();
            byte IsActive = chkIsActive.Checked ? (byte)1 : (byte)0;
            User U=new User(PersonId,IsActive,UserName,Password);
            int result = User.AddUser(U);
            if (result <= 0)
            {
                MessageBox.Show("User doesn't added try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"User added successfully! Your User ID = {result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetPage();
            }
        }
        private void EditUser(User U)
        {
            bool result = User.EditUser(U);
            if (!result)
            {
                MessageBox.Show("User doesn't edited try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"User edited successfully! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void ResetPage()
        {
            ctrPerson1.ResetControl();
            txtUSearchPerson.Text = "";
            txtUserName.Text = "";
            txtUserPass.Text = "";
            txtUserCPass.Text = "";
            chkIsActive.Checked = false;
            tabControl1.SelectedIndex = 0;
        }
        private User returnUserToBeEdited()
        {
            int userId = user.UserId;
            int PersonId = user.PersonId;
            string UserName = txtUserName.Text.ToString();
            string Password = txtUserPass.Text.ToString();
            byte IsActive = chkIsActive.Checked ? (byte)1 : (byte)0;
            User Us = new User(PersonId,userId, IsActive, UserName, Password);
            return Us;
        }
        private void btnPCSave_Click(object sender, EventArgs e)
        {
            if (CheckValdation())
            {
                if (_mode == 1)
                {
                    AddUser();
                }
                else if (_mode == 2) {
                    EditUser(returnUserToBeEdited());
                }
                    UserAdded?.Invoke();
            }
        }

        private void txtUserCPas_Validating(object sender, CancelEventArgs e)
        {
            string TName = txtUserCPass.Text.Trim();

            if (string.IsNullOrEmpty(TName))
            {

                errorProvider1.SetError(txtUserCPass, "Third Name is required!");
                e.Cancel = true;
                return;

            }
            else
            {

                e.Cancel = false;
                errorProvider1.SetError(txtUserCPass, "");
            }

            if (txtUserCPass.Text != txtUserPass.Text)
            {
                errorProvider1.SetError(txtUserCPass, "Passwords do not match!");
                //e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtUserCPass, "");
            }
        }

        private void txtUserCPas_TextChanged(object sender, EventArgs e)
        {
            if (txtUserCPass.Text != txtUserPass.Text)
            {
                errorProvider1.SetError(txtUserCPass, "Passwords do not match!");
            }
            else
            {
                errorProvider1.SetError(txtUserCPass, "");
            }
        }

        private void txtUserPass_TextChanged(object sender, EventArgs e)
        {

        }

    
    }
}
