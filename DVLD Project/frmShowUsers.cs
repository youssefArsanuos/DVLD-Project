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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD_Project
{
    public partial class frmShowUsers : Form
    {
        private User user;
        public frmShowUsers()
        {
            InitializeComponent();
        }

        public void _RefreshHistory()
        {
            dvgUser.AutoGenerateColumns = true;
            dvgUser.DataSource = User.GetAllUsers();
            lblRecords.Text = dvgUser.Rows.Count.ToString();
        }

        private void fillSearchColumns()
        {
            cmbSearchUsers.Items.Clear();

            foreach (DataGridViewColumn col in dvgUser.Columns)
            {
                cmbSearchUsers.Items.Add(col.Name);
            }
            cmbIsActive.Items.Add("Yes");
            cmbIsActive.Items.Add("No");
        }
        private void frmUsersInfo_Load(object sender, EventArgs e)
        {
            _RefreshHistory();
            fillSearchColumns();
        }

        private void btnCloseUserFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvgUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _RefreshHistory();
        }

        private void cmbSearchUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSearchUsers_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _RefreshHistory();
            if (cmbSearchUsers.Text == "IsActive")
            {
                cmbIsActive.Visible = true;
                txtSearchUsers.Visible = false;
            }
            else
            {
                cmbIsActive.Visible = false;
                txtSearchUsers.Visible = true;
            }
        }

        private void search()
        {
            string search = txtSearchUsers.Text.ToString();
            string col = cmbSearchUsers.Text;
            dvgUser.AutoGenerateColumns = true;
            dvgUser.DataSource = User.SearchUser(col, search);
            //lblPeoplesNumber.Text = People.PeoplesSearchNumber(col, search).ToString();
            lblRecords.Text = dvgUser.Rows.Count.ToString();
            
        }

        private void txtSearchUsers_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void cmbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataTable dt = (DataTable)dvgUser.DataSource;

            int val = cmbIsActive.Text == "Yes" ? 1 : 0;

            dt.DefaultView.RowFilter = $"IsActive = {val}";

        }

        private void txtSearchUsers_TextChanged_1(object sender, EventArgs e)
        {
            search();
        }

        private void txtSearchUsers_TextChanged_2(object sender, EventArgs e)
        {
           
            search();
        }

        private void ShowAddUserForm()
        {
            frmAddOrEditUser frm = new frmAddOrEditUser(1);
            frm.UserAdded += _RefreshHistory; 
            frm.ShowDialog();
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ShowAddUserForm();
        }

        private void txtSearchUsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbSearchUsers.Text == "PersonId" || cmbSearchUsers.Text == "UserId")
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void dvgUser_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dvgUser.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dvgUser.ClearSelection();
                    dvgUser.Rows[hit.RowIndex].Selected = true;
                    dvgUser.CurrentCell = dvgUser.Rows[hit.RowIndex].Cells[0];
                }
            }
        }

        private void cntxPAddUser_Click(object sender, EventArgs e)
        {
            ShowAddUserForm();
        }

        private void DeleteUser()
        {
            if (dvgUser.CurrentRow == null)
            {
                MessageBox.Show("No row selected");
                return;
            }

            var id = dvgUser.CurrentRow.Cells["UserId"].Value;
            if (id == null)
            {
                MessageBox.Show("Invalid Id");
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this User?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
             
                    if (User.DeleteUser(id.ToString()))
                    {
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshHistory();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void ShowUserInfo()
        {
            if (dvgUser.CurrentRow == null)
            {
                MessageBox.Show("No row selected");
                return;
            }
            else
            {
                frmCurrentUserInfo frm = new frmCurrentUserInfo(GetUserFromGrid());
                frm.ShowDialog();
            }
        }
        private void ShowEditUserPass()
        {
            if (dvgUser.CurrentRow == null)
            {
                MessageBox.Show("No row selected");
                return;
            }
            else
            {
                frmChangeUserPassword frm = new frmChangeUserPassword(GetUserFromGrid());
                //frm.EditUser += _RefreshHistory;
                frm.ShowDialog();
            }
        }
        private void cntxPShowDetails_Click(object sender, EventArgs e)
        {
            ShowUserInfo();
        }

        private User GetUserFromGrid()
        {
            int userId = Convert.ToInt32(dvgUser.CurrentRow.Cells["UserId"].Value);
            string userName = dvgUser.CurrentRow.Cells["UserName"].Value.ToString();
            int personId = Convert.ToInt32(dvgUser.CurrentRow.Cells["PersonId"].Value);

            bool isActiveBool = Convert.ToBoolean(dvgUser.CurrentRow.Cells["IsActive"].Value);
            byte isActive = (byte)(isActiveBool ? 1 : 0);
            return new User(personId, isActive, userName, userId);
        }

        private void ShowEditUserForm()
        {
            if (dvgUser.CurrentRow == null)
            {
                MessageBox.Show("No row selected");
                return;
            }
            else
            {
                frmAddOrEditUser frm = new frmAddOrEditUser(2, GetUserFromGrid());
                frm.UserAdded += _RefreshHistory;
                frm.ShowDialog();
            }
        }

        private void cntxPEdit_Click(object sender, EventArgs e)
        {
            ShowEditUserForm();
        }

        private void cntxPDelete_Click(object sender, EventArgs e)
        {
            ShowEditUserPass();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ShowUserInfo();
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            ShowUserInfo();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ShowEditUserForm();
        }

        private void cntxPAddUser_Click_1(object sender, EventArgs e)
        {
            ShowAddUserForm();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void cntxPDelete_Click_1(object sender, EventArgs e)
        {
            ShowEditUserPass();
        }
    }
}
