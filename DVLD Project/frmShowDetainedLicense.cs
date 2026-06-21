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
    public partial class frmShowDetainedLicense : Form
    {
        private int _UserId;
        private string _UserName;
        public frmShowDetainedLicense(int userId, string userName)
        {
            InitializeComponent();
            _UserId = userId;
            _UserName = userName;
        }
        public void _RefreshHistory()
        {
            dvgDetainedLicense.AutoGenerateColumns = true;
            dvgDetainedLicense.DataSource = Licenses.GetDetainedLicenses();
            lblRecords.Text = dvgDetainedLicense.Rows.Count.ToString();
        }
        private void frmShowDetainedLicense_Load(object sender, EventArgs e)
        {
            _RefreshHistory();
            fillSearchColumns();
        }
        private void ShowPersonInfoForm()
        {
            if (dvgDetainedLicense.CurrentRow != null)
            {
                var id = dvgDetainedLicense.CurrentRow.Cells["PersonId"].Value;
                int PId = Convert.ToInt32(id);

                AddandDelete_Person frm = new AddandDelete_Person(3, PId);
                frm.ShowDialog();
            }
        }
        private void Search()
        {
            string search = txtSearchDrivers.Text.Trim();
            string col = cmbSearchDrivers.Text;

            DataView dv = ((DataTable)dvgDetainedLicense.DataSource).DefaultView;

            if (string.IsNullOrEmpty(search))
            {
                dv.RowFilter = "";
            }
            else
            {
                if (col == "DetainId" || col == "LicenseId" || col == "FineFees")
                {
                    if (int.TryParse(search, out int num))
                        dv.RowFilter = $"{col} = {num}";
                    else
                        dv.RowFilter = "1 = 0";
                }
                else
                {
                    dv.RowFilter = $"CONVERT([{col}], System.String) LIKE '%{search}%'";
                }
            }
        }
        private void fillSearchColumns()
        {
            cmbSearchDrivers.Items.Clear();

            foreach (DataGridViewColumn col in dvgDetainedLicense.Columns)
            {
                cmbSearchDrivers.Items.Add(col.Name);
            }

        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            DetainLicense frm = new DetainLicense(_UserId, _UserName);
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense(_UserId, _UserName);
            frm.ShowDialog();
        }

        private void dvgDetainedLicense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _RefreshHistory();
        }

        private void btnCloseUserFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvgDetainedLicense_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dvgDetainedLicense.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dvgDetainedLicense.ClearSelection();
                    dvgDetainedLicense.Rows[hit.RowIndex].Selected = true;
                    dvgDetainedLicense.CurrentCell = dvgDetainedLicense.Rows[hit.RowIndex].Cells[0];
                }
            }
        }

        private void txtSearchDrivers_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ShowPersonInfoForm();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            int LDLAID = Licenses.GetLDLAID(Convert.ToInt32(dvgDetainedLicense.CurrentRow.Cells["LicenseId"].Value));

            frmShowLicenseInfo frm = new frmShowLicenseInfo(LDLAID);

            frm.ShowDialog();
        }

        private void cntxPDelete_Click(object sender, EventArgs e)
        {
            frmShowLicenseHistory frm = new frmShowLicenseHistory(Convert.ToString(dvgDetainedLicense.CurrentRow.Cells["NotionalNo"].Value));
            frm.ShowDialog();
        }
    }
}
