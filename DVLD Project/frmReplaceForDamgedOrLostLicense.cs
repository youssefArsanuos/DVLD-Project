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

    public partial class frmReplaceForDamgedOrLostLicense : Form
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
        private DataTable _OldLicense;

        public frmReplaceForDamgedOrLostLicense(int userId, string userName)
        {
            InitializeComponent();
            _UserId=userId;
            _UserName=userName;
        }
        private bool CheckValidation()
        {
            if (!Licenses.IsLicenseExist(txtSearchLicense.Text.ToString()))
            {
                MessageBox.Show("Invalid license id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Licenses.IsLicenseActive(txtSearchLicense.Text))
            {
                MessageBox.Show("This license is inactive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void FillAllData()
        {
            ctrDriverLicenseInfo1.LicenseId = txtSearchLicense.Text;
            btnIssue.Enabled = true;
            linkLabel1.Enabled = true;
            _OldLicense=Licenses.GetAllLicenseInfo(txtSearchLicense.Text.ToString());
        }
        private int AddApplication()
        {
            DataTable dt = Licenses.GetLicenseClassInformation(ctrDriverLicenseInfo1.ClassName);
            DataRow row = dt.Rows[0];

            _LicenseClassId = Convert.ToInt32(row["LicenseClassId"].ToString());
            _ClassFees = Convert.ToDecimal(row["ClassFees"].ToString());
            _ValidityYears = Convert.ToInt32(row["DefaultValidityLength"].ToString());
            int personId = People.ReturnPersonId(ctrDriverLicenseInfo1.NationalNo);
            int ApplicationClass = 0;
            if (rdbDamgedLicense.Checked == true) { ApplicationClass = 5; 
                _AppFees=Applications.GetReplaceDamagedLicenseFees();
            }
            if (rdbLostLicense.Checked == true) { ApplicationClass = 4;
                _AppFees = Applications.GetReplaceLostLicenseFees();
            }

            Applications app = new Applications(personId, _UserId, ApplicationClass, DateTime.Now, 0, DateTime.Now, _AppFees, _LicenseClassId);
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

        private void FillAppData()
        {
            lbApplicationId.Text = Convert.ToString(_ApplicationId);
            DateTime today = DateTime.Now;
            lblApplicationDate.Text = today.ToString("dd/MM/yyyy");
            lblAppFees.Text = Convert.ToString(_AppFees);
            lbloldLicenseId.Text = ctrDriverLicenseInfo1.LicenseId;
            lblCreatedBy.Text = _UserName;
            decimal TotalFees = _AppFees + _ClassFees;

        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                FillAllData();
                _OldLicense = Licenses.GetAllLicenseInfo(txtSearchLicense.Text);
                gbxFilter.Enabled = false;
                gbxReplacementFor.Enabled = false;
            }
        }

        private void frmReplaceForDamgedOrLostLicense_Load(object sender, EventArgs e)
        {
            rdbDamgedLicense.Checked = true;
        }

        private void rdbDamgedLicense_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbDamgedLicense.Checked == true)
            {
                txtHead.Text = "Replacement For Damaged License";
            }
            else
            {
                txtHead.Text = "Replacement For Lost License";
            }
        }

        private void rdbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLostLicense.Checked == true)
            {
                txtHead.Text = "Replacement For Lost License";
            }
            else
            {
                txtHead.Text = "Replacement For DamagedLost License";
            }
        }

        private void ReplacementLicense()
        {
            DataRow row=_OldLicense.Rows[0];
            byte issueReason = 0;
            if (rdbDamgedLicense.Checked == true)
            {
                issueReason = 5;

            }
            if (rdbLostLicense.Checked == true)
            {
                issueReason = 4;

            }
            Licenses license = new Licenses(_ApplicationId, Convert.ToInt32(ctrDriverLicenseInfo1.DriverId), _LicenseClassId, _ValidityYears, "", _ClassFees, true, issueReason, _UserId, false);
            _licenseId = Licenses.AddNewLicense(license,Convert.ToDateTime(row["IssueDate"]));
            Applications.CompletelApplication(_licenseId.ToString());
            lblReplaceLicense.Text = _licenseId.ToString();

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
            _ApplicationId = AddApplication();
            FillAppData();
            ReplacementLicense();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frm = new frmShowLicenseHistory(ctrDriverLicenseInfo1.NationalNo);
            frm.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_LDLAId);
            frm.ShowDialog();
        }

        private void btnCloseUserFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frm = new frmShowLicenseHistory(ctrDriverLicenseInfo1.NationalNo);
            frm.ShowDialog();
        }
    }
}
