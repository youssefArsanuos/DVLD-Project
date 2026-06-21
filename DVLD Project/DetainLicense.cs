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
    public partial class DetainLicense : Form
    {
        private int _UserId;
        private string _UserName;
        public DetainLicense(int UserId,string UserName)
        {
            InitializeComponent();
            _UserId = UserId;
            _UserName = UserName;
        }

        private void gbxFilter_Enter(object sender, EventArgs e)
        {

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
            if (Licenses.IsLicenseDetained(txtSearchLicense.Text))
            {
                MessageBox.Show("This license is already detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void FillAllData()
        {
            ctrDriverLicenseInfo1.LicenseId = txtSearchLicense.Text;
            btnDetain.Enabled = true;
            linkLabel1.Enabled = true;
            lblDetainDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblLicenseId.Text = txtSearchLicense.Text;
            lblCreatedBy.Text = _UserName;
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                FillAllData();

            }
        }

        private void DetainLicense_Load(object sender, EventArgs e)
        {

        }
        private void DetainNewLicense()
        {
            if (string.IsNullOrWhiteSpace(txtFineFees.Text))
            {
                MessageBox.Show("Please enter Fine Fees", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFineFees.Focus();
                return;
            }
            int DetainId = Licenses.DetainLicense(txtSearchLicense.Text, _UserId.ToString(), txtFineFees.Text);
            btnDetain.Enabled = false;
            
            if (DetainId == -1)
            {
                MessageBox.Show("An error ocurred try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            lblDetainId.Text = DetainId.ToString();
            gbxFilter.Enabled = false;
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            DetainNewLicense();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frm = new frmShowLicenseHistory(ctrDriverLicenseInfo1.NationalNo);
            frm.ShowDialog();
        }

        private void btnCloseUserFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
