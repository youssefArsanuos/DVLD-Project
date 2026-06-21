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
using System.IO;
namespace DVLD_Project
{
    public partial class frmIssueInternationalLicense : Form
    {
        private int _licenseId;
        public frmIssueInternationalLicense()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int Int_LicenseId= Convert.ToInt32(lblInterLicense.Text.Trim());
            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(Int_LicenseId);
            frm.ShowDialog();
        }

        private void btnCloseUserFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool SearchValidation()
        {
            if (string.IsNullOrWhiteSpace(txtSearchLicense.Text))
            {

                MessageBox.Show("Enter License Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Licenses.IsLicenseExist(txtSearchLicense.Text.ToString()))
            {

                MessageBox.Show("Wrong License ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Licenses.CheckIfLicenseInClass3(txtSearchLicense.Text.ToString()))
            {

                MessageBox.Show("This license category is not suitable for issuing an international license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Licenses.CheckIfPersonHasAnActiverInternationalLicense(txtSearchLicense.Text.ToString()))
            {

                MessageBox.Show("This person already has an active international license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
               
            }
            return true;
        }

        private void FillAllData()
        {
           
            ctrDriverLicenseInfo1.LicenseId = txtSearchLicense.Text.ToString();
            btnIssue.Enabled = true;
            linkLabel1.Enabled = true;
            linkLabel2.Enabled = true;
           
        }
        private int AddLicense(int ApplicationId,DataRow row)
        {
            int ValidityYears = Convert.ToInt32(row["ValidityYears"].ToString());
            int UserId = Convert.ToInt32(row["CreatedByUserId"].ToString());
            decimal Fees = Convert.ToDecimal(row["ClassFees"].ToString());
            Licenses lic = new Licenses(ApplicationId, Convert.ToInt32(ctrDriverLicenseInfo1.DriverId),3, ValidityYears, "",Fees, true, 7, UserId,true);
            return  Licenses.AddNewInternationlLicense(lic,Convert.ToInt32(txtSearchLicense.Text.ToString()));
        }
        private void FillApplicationInfo(int ApplicationId)
        {
            DataTable dt = Applications.GetApplicationAndI_LInfo(ApplicationId);
            if (dt.Rows.Count == 0)
                return;
            DataRow row = dt.Rows[0];
            lbApplicationId.Text = row["ApplicationId"].ToString();
            lblApplicationDate.Text = row["ApplicationDate"].ToString();
            lblIssueAppDate.Text= row["IssueDate"].ToString();
            lblFees.Text = row["PaidFees"].ToString();
            lblInterLicense.Text = row["Int_LicenseId"].ToString();
           
            lblLocalLicenseId.Text=ctrDriverLicenseInfo1.LicenseId;
            lblAppExipirationDate.Text = row["ExpirationDate"].ToString();
            lblCreatedBy.Text = row["CreatedByUserId"].ToString();
        }
        private int AddApplication(DataRow row)
        {
            int PersonId = Convert.ToInt32(row["PersonId"].ToString());
            int UserId= Convert.ToInt32(row["CreatedByUserId"].ToString());
            Applications app = new Applications(PersonId, UserId, 7, DateTime.Now, 0,
                                                                  DateTime.Now, Applications.GetInterNationalLicenseFees(),
                                                                  3);
          return Applications.AddApplicatoin(app);

        }
     
        private void Search()
        {
            if (SearchValidation())
            {
                FillAllData();
            }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void frmIssueInternationalLicense_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frm = new frmShowLicenseHistory(ctrDriverLicenseInfo1.NationalNo);
            frm.ShowDialog();
        }
        private void IssueLicense()
        {
            DataTable dt = Licenses.GetLicenseInfoWithLicenseId(txtSearchLicense.Text.ToString());
            if (dt.Rows.Count == 0)
                return;
            DataRow row = dt.Rows[0];
            int ApplicationId = AddApplication(row);
            if (ApplicationId == -1)
            {
                MessageBox.Show("An Error occured try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int LicenseId = AddLicense(ApplicationId, row);
            FillApplicationInfo(ApplicationId);
            btnIssue.Enabled = false;
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            IssueLicense();
        }
    }
}
