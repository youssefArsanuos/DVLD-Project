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
    public partial class frmShowInternationalLicenses : Form
    {
        public frmShowInternationalLicenses()
        {
            InitializeComponent();
        }

        private void btnCloseUserFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void IssueInternationalLicenseForm()
        {
            frmIssueInternationalLicense frm = new frmIssueInternationalLicense();
            frm.ShowDialog();
        }
        private void frmShowInternationalLicenses_Load(object sender, EventArgs e)
        {
            _RefreshHistory();
            fillSearchColumns();
        }
        private void ShowPersonInfoForm()
        {
            if (dvgApplications.CurrentRow != null)
            {
                var id = dvgApplications.CurrentRow.Cells["DriverId"].Value;
                int PId = People.GetPersonIdUsingDriverId(Convert.ToInt32(id));

                AddandDelete_Person frm = new AddandDelete_Person(3, PId);
                frm.ShowDialog();
            }
        }
        public void _RefreshHistory()
        {
            dvgApplications.AutoGenerateColumns = true;
            dvgApplications.DataSource = Licenses.getInternationalLicensesRecords();
            lblRecords.Text = dvgApplications.Rows.Count.ToString();
        }
        private void fillSearchColumns()
        {
            cmbSearchApplications.Items.Clear();

            foreach (DataGridViewColumn col in dvgApplications.Columns)
            {
                cmbSearchApplications.Items.Add(col.Name);
            }

        }
        private void Search()
        {
            string search = txtSearchUsers.Text.Trim();
            string col = cmbSearchApplications.Text;

            DataView dv = Licenses.getInternationalLicensesRecords().DefaultView;

            if (string.IsNullOrEmpty(search))
            {
                dv.RowFilter = "";
            }
            else
            {
                if (col == "LicenseId" ||
                    col == "ApplicationId" ||
                    col == "localLicenseId")
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

            dvgApplications.DataSource = dv;
            lblRecords.Text = dvgApplications.Rows.Count.ToString();
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            IssueInternationalLicenseForm();
        }

        private void txtSearchUsers_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dvgApplications_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dvgApplications.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dvgApplications.ClearSelection();
                    dvgApplications.Rows[hit.RowIndex].Selected = true;
                    dvgApplications.CurrentCell = dvgApplications.Rows[hit.RowIndex].Cells[0];
                }
            }
        }

        private void cntxShowApplictionDetails_Click(object sender, EventArgs e)
        {
            
            ShowPersonInfoForm();
        }

        

        
        private void cntxShowLicense_Click(object sender, EventArgs e)
        {
            var id = dvgApplications.CurrentRow.Cells["LicenseId"].Value;
            int Int_LicenseId = Convert.ToInt32(id);
            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(Int_LicenseId);
                frm.ShowDialog() ;
        }

        private void cmbxLicensesHistory_Click(object sender, EventArgs e)
        {
            if (dvgApplications.CurrentRow != null)
            {
                var id = dvgApplications.CurrentRow.Cells["DriverId"].Value;
                int PId = People.GetPersonIdUsingDriverId(Convert.ToInt32(id));
                string NationalNo = People.ReturnNationalNo(PId);

                frmShowLicenseHistory frm = new frmShowLicenseHistory(NationalNo);
                frm.ShowDialog();
            }
        }
    }
}
