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
    public partial class Form1 : Form
    {
        frmLogin _frmLogin;
        private User user;
        public Form1(frmLogin frm,User U)
        {
            InitializeComponent();
            _frmLogin = frm;
            user = U;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPeoples frm = new frmShowPeoples();
            frm.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_isLogout)
                Application.Exit();
            _isLogout = false;
        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void showCurrentUserInfo()
        {
            frmCurrentUserInfo frm = new frmCurrentUserInfo(user);
            frm.ShowDialog();
        }
        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showCurrentUserInfo();
        }

        private bool _isLogout = false;
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmLogin.Show();
            _isLogout = true;
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUsers frm = new frmShowUsers();
            frm.ShowDialog();
        }

        private void ShowChangePassForm()
        {
            frmChangeUserPassword frm = new frmChangeUserPassword(user);
            frm.ShowDialog();
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChangePassForm();
        }

        private void ShowApplicationTypesForm()
        {
            frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void ShowTestTypesForm()
        {
            frmTestTypes frm = new frmTestTypes();
            frm.ShowDialog();
        }
        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowApplicationTypesForm();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTestTypesForm();
        }
        private void ShowLocalLicenseForm()
        {
            frmAddLocalLicense frm = new frmAddLocalLicense(user);
            frm.ShowDialog();
        }
        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLocalLicenseForm();
        }

        private  void ShowApplicationsForm()
        {
            frmShowApplicationscs frm = new frmShowApplicationscs(user);
            frm.ShowDialog();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ShowApplicationsForm();
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            ShowApplicationsForm();
        }

        private void ShowDriversInfo()
        {
            frmShowDrivers frm = new frmShowDrivers();
            frm.ShowDialog();
        }
        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDriversInfo();
        }

        private void IssueInternationalLicenseForm()
        {
            frmIssueInternationalLicense frm = new frmIssueInternationalLicense();
            frm.ShowDialog();
        }
        private void ShowInternationalLicensesForm()
        {
            frmShowInternationalLicenses frm = new frmShowInternationalLicenses();
            frm.ShowDialog();
        }
        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueInternationalLicenseForm();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ShowInternationalLicensesForm();
        }

        private void showRenewLicenseForm()
        {
            frmRenewLicense frm = new frmRenewLicense(user.UserId,user.UserName);
            frm.ShowDialog();   
        }
        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showRenewLicenseForm();
        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplaceForDamgedOrLostLicense frm=new frmReplaceForDamgedOrLostLicense(user.UserId,user.UserName);
            frm.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetainLicense frm = new DetainLicense(user.UserId, user.UserName);
            frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm =new frmReleaseDetainedLicense(user.UserId,user.UserName);
            frm.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmShowDetainedLicense frm = new frmShowDetainedLicense(user.UserId, user.UserName);
            frm.ShowDialog();
        }
    }
}
