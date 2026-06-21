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
    public partial class frmReleaseDetainedLicense : Form
    {
        private int _UserId;
        private string _UserName;
        private int _AppId;
        private decimal _AppFees;
        DataTable dt;
        public frmReleaseDetainedLicense(int userid,string username)
        {
            InitializeComponent();
            _UserId = userid;
            _UserName = username;
        }

        private void btnCloseUserFrm_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (!Licenses.IsLicenseDetained(txtSearchLicense.Text))
            {
                MessageBox.Show("This license is not detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                FillAllData();

            }
        }
        private void FillAllData()
        {
            dt=Licenses.GetDetainedLicenseInfo(txtSearchLicense.Text.ToString());
            DataRow row = dt.Rows[0];
            ctrDriverLicenseInfo1.LicenseId = txtSearchLicense.Text;
            btnRelease.Enabled = true;
            linkLabel1.Enabled = true;
            lblDetainDate.Text = row["DetainDate"].ToString();
            lblLicenseId.Text = txtSearchLicense.Text;
            lblCreatedBy.Text = _UserName;
            lblFineFees.Text= row["FineFees"].ToString();
            lblDetainId.Text = row["DetainId"].ToString();
            
        }
        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frm = new frmShowLicenseHistory(ctrDriverLicenseInfo1.NationalNo);
            frm.ShowDialog();
        }

        private int AddApplication()
        {
            
            int ApplicationClass = 6;
            int personId = People.ReturnPersonId(ctrDriverLicenseInfo1.NationalNo);
            _AppFees = Applications.GetRealesedDetainedLicenseFees();
         

            Applications app = new Applications(personId, _UserId, ApplicationClass, DateTime.Now, 1, DateTime.Now, _AppFees, -1);
            _AppId = Applications.AddRealeseDetainedLicenseApplicatoin(app);
            if (_AppId == -1)
            {
                MessageBox.Show("An error ocurred try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            return _AppId;
        }
        
        private void ReleaseLicense()
        {
            _AppId = AddApplication();
            lblAppId.Text=_AppId.ToString();
            lblAppFees.Text=_AppFees.ToString();
            decimal FineFees = Convert.ToDecimal(lblFineFees.Text);
            decimal TotalFees = FineFees + _AppFees;
            lblTotalFees.Text = TotalFees.ToString();
            Licenses.ReleasedLicense(txtSearchLicense.Text, _UserId, _AppId);
            btnRelease.Enabled = false;
            gbxFilter.Enabled = false;
        }
        private void btnDetain_Click(object sender, EventArgs e)
        {
            ReleaseLicense();
        }
    }
}
