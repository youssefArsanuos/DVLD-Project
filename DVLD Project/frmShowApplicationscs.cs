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
    public partial class frmShowApplicationscs : Form
    {
        User user;
        public frmShowApplicationscs(User u)
        {
            InitializeComponent();
            user = u;
        }
        private void Search()
        {
            string search = txtSearchUsers.Text.Trim();
            string col = cmbSearchApplications.Text;

            DataView dv = Applications.GetApplicationRecords().DefaultView;

            if (string.IsNullOrEmpty(search))
            {
                dv.RowFilter = "";
            }
            else
            {
                if (col == "LocalDrivingLicenseApplicationId" ||
                    col == "TestsCount" ||
                    col == "ApplicationStatus")
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



        private void txtSearchUsers_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnCloseUserFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void _RefreshHistory()
        {
            dvgApplications.AutoGenerateColumns = true;
            dvgApplications.DataSource = Applications.GetApplicationRecords();
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
        private void frmShowApplicationscs_Load(object sender, EventArgs e)
        {
            _RefreshHistory();
            fillSearchColumns();
        }

        private void dvgApplications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _RefreshHistory();
        }
        private void ShowAddApplicationForm()
        {
            frmAddLocalLicense frm = new frmAddLocalLicense(user);
            frm.ApplicationAdded += _RefreshHistory;
            frm.ShowDialog();
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ShowAddApplicationForm();
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

        private void cntxApplicatoins_Opening(object sender, CancelEventArgs e)
        {

        }
        private void DeleteApplication()
        {
            if (dvgApplications.CurrentRow == null)
            {
                MessageBox.Show("No row selected");
                return;
            }

            var id = dvgApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationId"].Value;
            if (id == null)
            {
                MessageBox.Show("Invalid Id");
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this Application?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                if (Applications.DeleteApplication(id.ToString()))
                {
                    MessageBox.Show("Application deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshHistory();
                }
                else
                {
                    MessageBox.Show("An error occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DeleteApplication();
        }
         private void ShowApplicationDetails()
        {
            var id = dvgApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationId"].Value;
            int LocalLicenseId = Convert.ToInt32(id);
            frmShowDetailsOfAppliction frm = new frmShowDetailsOfAppliction(LocalLicenseId);
            frm.ShowDialog();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ShowApplicationDetails();
        }

        private void CancelApplication()
        {
            if (dvgApplications.CurrentRow == null)
            {
                MessageBox.Show("No row selected");
                return;
            }

            var id = dvgApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationId"].Value;
            if (id == null)
            {
                MessageBox.Show("Invalid Id");
                return;
            }
            if (MessageBox.Show("Are you sure you want to cancel this Application?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                if (Applications.CancelApplication(id.ToString()))
                {
                    MessageBox.Show("Application canceled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshHistory();
                }
                else
                {
                    MessageBox.Show("An error occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void cntxCancelApplication_Click(object sender, EventArgs e)
        {
            CancelApplication();
        }

        private void SelectEnabledMenueItems()
        {
            foreach (ToolStripItem item in cntxApplicatoins.Items) item.Enabled = true;
            cntxSechduleVisionTest.Enabled = true;
            cntxcntxSechduleWrittenTest.Enabled = true;
            cntxSechduleStreetTests.Enabled = true;
            cntxIssueDrivingLicense.Enabled = false;
            cntxShowLicense.Enabled = false;
            var LocalLicenseID = dvgApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationId"].Value;
            string ApplicationStatus = dvgApplications.CurrentRow.Cells["ApplicationStatus"].Value.ToString();
            if(ApplicationStatus == "Cancelled")
            {
                foreach (ToolStripItem item in cntxApplicatoins.Items) item.Enabled = false;
                cntxDelete.Enabled = true;
                cntxShowApplictionDetails.Enabled = true;
                cntxShowPersonLicenseHistory.Enabled = true;    
            }
            if (LocalLicenseID == null)
            {
                MessageBox.Show("Invalid Id");
                return;
            }

            int LDLAID = Convert.ToInt32(LocalLicenseID);

            if (Tests.CheckIfPersonPassTest(LDLAID, "Vision Test"))
            {
                cntxSechduleVisionTest.Enabled = false;
            }

            if (!Tests.CheckIfPersonPassTest(LDLAID, "Vision Test") ||
                 Tests.CheckIfPersonPassTest(LDLAID, "Written Test"))
            {
                cntxcntxSechduleWrittenTest.Enabled = false;
            }

            if (!Tests.CheckIfPersonPassTest(LDLAID, "Written Test") ||
                 Tests.CheckIfPersonPassTest(LDLAID, "Street Test"))
            {
                cntxSechduleStreetTests.Enabled = false;
            }
            if (Tests.CheckIfPersonPassAllTests(LDLAID.ToString()))
            {
                cntxSechduleTests.Enabled = false;
                cntxIssueDrivingLicense.Enabled = true;
            }
            if (ApplicationStatus == "Completed")
            {
                foreach (ToolStripItem item in cntxApplicatoins.Items) item.Enabled = false;
                cntxShowApplictionDetails.Enabled = true;
                cntxShowLicense.Enabled = true;
                cntxShowPersonLicenseHistory.Enabled = true;
            }
        }
        private void cntxApplicatoins_Opening_1(object sender, CancelEventArgs e)
        {
            SelectEnabledMenueItems(); 
        }

        private void cntxSechduleVisionTest_Click(object sender, EventArgs e)
        {
            
            ShowTestAppointmentForm(1, LocalLicenseId());
        }

        private int LocalLicenseId()
        {
            var id = dvgApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationId"].Value;
            int LocalLicenseId = Convert.ToInt32(id);
            return LocalLicenseId;
        }
        private void ShowTestAppointmentForm(int mode,int id)
        {
            frmAppointmentTest frm=new frmAppointmentTest(mode, id);
            frm.TestChanges += _RefreshHistory;
            frm.TestAdded += SelectEnabledMenueItems;
            frm.ShowDialog();
        }

        private void cntxcntxSechduleWrittenTest_Click(object sender, EventArgs e)
        {
            ShowTestAppointmentForm(2, LocalLicenseId());
        }

        private void cntxSechduleStreetTests_Click(object sender, EventArgs e)
        {
            ShowTestAppointmentForm(3, LocalLicenseId());
        }

        private void cntxSechduleTests_Click(object sender, EventArgs e)
        {

        }
        private void CompleteApplication(int id)
        {
            Applications.CompletelApplication(id.ToString());
        }

        private void IssueDrivingLicenseForm()
        {
            var id = dvgApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationId"].Value;
            int LocalLicenseId = Convert.ToInt32(id);

            IssueDrivingLicense frm = new IssueDrivingLicense(LocalLicenseId);

            frm.IssueCompleted += () => CompleteApplication(LocalLicenseId);
            frm.IssueCompleted += _RefreshHistory;

            frm.ShowDialog();
        }
        private void cntxIssueDrivingLicense_Click(object sender, EventArgs e)
        {
            IssueDrivingLicenseForm();
        }

        private void ShowLicenseInfoForm()
        {
            int LDLAID = Convert.ToInt32(dvgApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationId"].Value);

            frmShowLicenseInfo frm = new frmShowLicenseInfo(LDLAID);

            frm.ShowDialog();
        }
        private void cntxShowLicense_Click(object sender, EventArgs e)
        {
            ShowLicenseInfoForm();
        }
        private void ShowPersonLicensesHistory()
        {
            string NationalNo = dvgApplications.CurrentRow.Cells["NotionalNo"].Value.ToString();

            frmShowLicenseHistory frm = new frmShowLicenseHistory(NationalNo);

            frm.ShowDialog();
        }
        private void cntxShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            ShowPersonLicensesHistory();
        }
    }
}
