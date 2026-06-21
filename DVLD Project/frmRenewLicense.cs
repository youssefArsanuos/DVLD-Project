using BusinLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmRenewLicense : Form
    {
        private int _ApplicationId;
        private int _UserId;
        private int _LicenseClassId;
        private decimal _ClassFees;
        private decimal _AppFees;
        private int _ValidityYears;
        private string _UserName;
        private int _licenseId;
        private int _LDLAId;
        public frmRenewLicense(int userId,string userName)
        {
            InitializeComponent();
            _UserId = userId;
            _UserName = userName;
        }

        private void btnCloseUserFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblTotalFees_Click(object sender, EventArgs e)
        {

        }

        private bool CheckValidation()
        {
            if (!Licenses.IsLicenseExist(txtSearchLicense.Text.ToString()))
            {
                MessageBox.Show("Invalid license id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            DateTime ExpirationDate = Licenses.GetLicenseExpirationDate(Convert.ToInt32(txtSearchLicense.Text.ToString()));
            if (DateTime.Now < ExpirationDate)
            {
                MessageBox.Show("This license is still valid and will expire on " + ExpirationDate.ToString("dd/MM/yyyy"));
                return false;
            }
            if (Licenses.IsUserHaveAnotherActiveLicense(txtSearchLicense.Text.ToString()))
            {
                MessageBox.Show("This person has another active license from this class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void FillAllData()
        {
            ctrDriverLicenseInfo1.LicenseId = txtSearchLicense.Text;
            btnIssue.Enabled = true;
            linkLabel1.Enabled = true;
        }
        private void FillAppData()
        {
            lbApplicationId.Text = Convert.ToString(_ApplicationId);
            DateTime today = DateTime.Now;
            lblApplicationDate.Text = today.ToString("dd/MM/yyyy");
            lblIssueAppDate.Text = today.ToString("dd/MM/yyyy");
            lblAppExipirationDate.Text = today.AddYears(_ValidityYears).ToString("dd/MM/yyyy");
            lblAppFees.Text = Convert.ToString(_AppFees);
            lblLicenseFees.Text = Convert.ToString(_ClassFees);
            lbloldLicenseId.Text = ctrDriverLicenseInfo1.LicenseId;
            lblCreatedBy.Text = _UserName;
            decimal TotalFees = _AppFees + _ClassFees;
            lblTotalFees.Text = TotalFees.ToString();

        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                FillAllData();
                _ApplicationId = AddApplication();
                FillAppData();
            }
        }

        private void frmRenewLicense_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frm = new frmShowLicenseHistory(ctrDriverLicenseInfo1.NationalNo);
            frm.ShowDialog();
        }
        private int AddApplication()
        {
            DataTable dt = Licenses.GetLicenseClassInformation(ctrDriverLicenseInfo1.ClassName);
            DataRow row = dt.Rows[0];

            _LicenseClassId = Convert.ToInt32(row["LicenseClassId"].ToString());
            _ClassFees = Convert.ToDecimal(row["ClassFees"].ToString());
            _AppFees = Applications.GetRenewDrivingLicenseFees();
            _ValidityYears= Convert.ToInt32(row["DefaultValidityLength"].ToString());
            int personId = People.ReturnPersonId(ctrDriverLicenseInfo1.NationalNo);
            Applications app = new Applications(personId,_UserId,3,DateTime.Now,0,DateTime.Now,_AppFees,_LicenseClassId);
            int[] ids = Applications.AddNewApplicatoin(app);
            _ApplicationId = ids[0];
            _LDLAId = ids[1];
            if (_ApplicationId == -1)
            {
                MessageBox.Show("An error ocurred try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            return _ApplicationId;
        }
        private void RenewLicense()
        {
            Licenses license = new Licenses(_ApplicationId, Convert.ToInt32(ctrDriverLicenseInfo1.DriverId),_LicenseClassId,_ValidityYears,txtAppNotes.Text,_ClassFees,true,3,_UserId,false);
            _licenseId=Licenses.AddNewLicense(license);
            Applications.CompletelApplication(_licenseId.ToString());
            lblRenewLicense.Text=_licenseId.ToString();
            txtAppNotes.Enabled = false;
            btnIssue.Enabled = false;
            if (_licenseId == -1)
            {
                MessageBox.Show("An error ocurred try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            linkLabel2.Enabled = true;
            Licenses.DeactivateOldLicense(lbloldLicenseId.Text);
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            RenewLicense();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_LDLAId);
            frm.ShowDialog();
        }
    }
}
