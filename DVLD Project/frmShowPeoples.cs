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
using BusinLayer;
namespace DVLD_Project
{
    public partial class frmShowPeoples : Form
    {
        public frmShowPeoples()
        {
            InitializeComponent();
        }

        public void _RefreshHistory()
        {
            dvgPeople.AutoGenerateColumns = true;
            dvgPeople.DataSource = People.GetAllPeoples();
            lblPeoplesNumber.Text= dvgPeople.Rows.Count.ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _RefreshHistory();
        }

        private void btnClosePeopleFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowPeoples_Load(object sender, EventArgs e)
        {
            _RefreshHistory();
            _getPeopleColumns();
        }

        private void dvgPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _RefreshHistory();
        }

        private void dvgPeople_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dvgPeople.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dvgPeople.ClearSelection();
                    dvgPeople.Rows[hit.RowIndex].Selected = true;
                    dvgPeople.CurrentCell = dvgPeople.Rows[hit.RowIndex].Cells[0];
                }
            }
        }

        private void ShowPersonInfoForm()
        {
            if (dvgPeople.CurrentRow != null)
            {
                var id = dvgPeople.CurrentRow.Cells["PersonId"].Value;
                int PId = Convert.ToInt32(id);

                AddandDelete_Person frm = new AddandDelete_Person(3, PId);
                frm.ShowDialog();
            }
        }
        private void cntxPShowDetails_Click(object sender, EventArgs e)
        {
            ShowPersonInfoForm();
            //if (dvgPeople.CurrentRow != null)
            //{

            //    var id = dvgPeople.CurrentRow.Cells["PersonId"].Value;
            //    // name = dvgPeople.CurrentRow.Cells["Name"].Value;

            //    MessageBox.Show($"ID: {id}");
            //}

        }

        private void cntxPDelete_Click(object sender, EventArgs e)
        {
            if (dvgPeople.CurrentRow == null)
            {
                MessageBox.Show("No row selected");
                return;
            }

            var id = dvgPeople.CurrentRow.Cells["PersonId"].Value;
            if (id == null)
            {
                MessageBox.Show("Invalid Id");
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this Person?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (People.CheckIfPersonIsUser(id.ToString()))
                {
                    MessageBox.Show("Can't delete this person because he is a user on the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (People.RemovePerson(id.ToString()))
                    {
                        MessageBox.Show("Person deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshHistory();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
           
        }

        private void cntxPEdit_Click(object sender, EventArgs e)
        {
            ShowEditForm();
           

        }
        private void ShowEditForm()
        {
            if (dvgPeople.CurrentRow != null)
            {
                var id = dvgPeople.CurrentRow.Cells["PersonId"].Value;
                int PId = Convert.ToInt32(id);

                AddandDelete_Person frm = new AddandDelete_Person(2, PId);
                frm.MyPersonControl.PersonAdded += _RefreshHistory;
                frm.ShowDialog();

            }
        }
        private void ShowAddForm()
        {
             AddandDelete_Person frm = new AddandDelete_Person(1);
            frm.MyPersonControl.PersonAdded += _RefreshHistory;
            frm.ShowDialog();
             

        }

        private void cntxPAddPerson_Click(object sender, EventArgs e)
        {
            ShowAddForm();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            ShowAddForm();
            
        }

        private void txtSearchPeoples_TextChanged(object sender, EventArgs e)
        {
            _SearchPeople();
        }

        private void _SearchPeople()
        {
            string search = txtSearchPeoples.Text.ToString();
            string col = cmbSearchPeoples.Text;
            dvgPeople.AutoGenerateColumns = true;
            dvgPeople.DataSource = People.SearchPeople(col,search);
            //lblPeoplesNumber.Text = People.PeoplesSearchNumber(col, search).ToString();
            lblPeoplesNumber.Text = dvgPeople.Rows.Count.ToString();
        }

        private void _getPeopleColumns()
        {
            //DataTable dt = People.GetPeopleColumns();

            //cmbSearchPeoples.DataSource = dt;
            //cmbSearchPeoples.DisplayMember = "COLUMN_NAME";
            cmbSearchPeoples.Items.Clear();

            foreach (DataGridViewColumn col in dvgPeople.Columns)
            {
                cmbSearchPeoples.Items.Add(col.Name);
            }
        }

        private void txtSearchPeoples_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbSearchPeoples.Text == "PersonId" || cmbSearchPeoples.Text == "Phone")
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
    }

    internal class Add_DeletePerson
    {
        private int v;
        private string pId;

        public Add_DeletePerson(int v, string pId)
        {
            this.v = v;
            this.pId = pId;
        }
    }
}

