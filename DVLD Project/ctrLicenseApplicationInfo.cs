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
    
    public partial class ctrLicenseApplicationInfo : UserControl
    {
        private int _Id;
        private string _LocalLicenseId;
        private int _PersonId;
        private int _LicenseClassId;
        private int _UserId;

        public int ApplicationId
        {
            get { return _Id; }
            set
            {
                _Id = value;
                FillApplicationInfo();
            }
        }
        public string LDLAId
        {
            get { return _LocalLicenseId; }
            set
            {
                _LocalLicenseId = value;
            }
        }
        public int LicenseClassId
        {
            get { return _LicenseClassId; }
            set
            {
                _LicenseClassId = value;
            }
        }
        public int UserId
        {
            get { return _UserId; }
            set
            {
                _UserId = value;
            }
        }

        public int PersonId
        {
            get { return _PersonId; }
            set
            {
                _PersonId = value;
            }
        }

        public ctrLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        private void lblDLAppId_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ctrLicenseApplicationInfo_Load(object sender, EventArgs e)
        {
             
        }
        private void FillApplicationInfo()
        {
            DataTable dt = Applications.getApplicationDetailsForCard(_Id.ToString());

            if (dt.Rows.Count == 0)
                return;

            DataRow row = dt.Rows[0];

            lblApplicationId.Text = row["ApplicationId"].ToString();
            lblApplicationStatus.Text = row["ApplicationStatus"].ToString();
            lblApplicationFees.Text = row["ApplicationFees"].ToString();
            lblApplicationType.Text = row["ApplicationTypeTitle"].ToString();
            lblApplicationApplicant.Text = row["FullName"].ToString();
            lblApplicationDate.Text = Convert.ToDateTime(row["ApplicationDate"]).ToShortDateString();
            lblApplicationStatusDate.Text = Convert.ToDateTime(row["LastStatusDate"]).ToShortDateString();
            lblApplicationUser.Text = row["UserName"].ToString();
            lblDLAppId.Text = row["LocalDrivingLicenseApplicationId"].ToString();
            _LocalLicenseId = lblDLAppId.Text.ToString();
            lblLicenseClassName.Text = row["ClassName"].ToString();
            lblPassedTests.Text = row["PassedTests"].ToString();
            _LicenseClassId = Convert.ToInt32(row["LicenseClassId"].ToString());
            _PersonId = Convert.ToInt32( row["PersonId"].ToString());
            _UserId =Convert.ToInt32(row["UserId"].ToString());
        }
        public void UpdatePassedTest()
        {
            DataTable dt = Applications.getApplicationDetails(_Id.ToString());

            if (dt.Rows.Count == 0)
                return;

            DataRow row = dt.Rows[0];
            lblPassedTests.Text = row["PassedTests"].ToString();

            
            //if (Convert.ToInt32(lblPassedTests.Text.ToString()) == 3)
            //{
            //    Applications.CompletelApplication(lblDLAppId.Text.ToString());
            //}
        }
        private void ShowPersonInfoForm()
        {
                AddandDelete_Person frm = new AddandDelete_Person(3, _PersonId);
                frm.ShowDialog();   
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPersonInfoForm();
        }
    }
}
