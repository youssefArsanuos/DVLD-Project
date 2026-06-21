using BusinLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmShowInternationalLicenseInfo : Form
    {
        private int _LicenseId;
        public frmShowInternationalLicenseInfo(int licenseId)
        {
            InitializeComponent();
            _LicenseId = licenseId;
        }

        private void btnClosePeopleFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FillAllData()
        {
            DataTable dt = Licenses.GetInterNationalLicenseInfo(_LicenseId);

            if (dt.Rows.Count == 0)
                return;

            DataRow row = dt.Rows[0];

            
            lblPersonName.Text = row["FullName"].ToString();
            lblIntrLicenseId.Text = row["Int_LicenseId"].ToString();
            lblLicenseId.Text = row["LicenseId"].ToString();
            lblNationalNo.Text = row["NotionalNo"].ToString();
            lblApplicationId.Text = row["ApplicationId"].ToString();
            if (Convert.ToByte(row["Gendor"]) == 0)
                lblGendor.Text = "Male";
            else
                lblGendor.Text = "Female";

            lblIssueDate.Text = Convert.ToDateTime(row["IssueDate"]).ToShortDateString();
            

            if (Convert.ToBoolean(row["IsActive"]))
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";

            lblDateOfBirth.Text = Convert.ToDateTime(row["DateOfBirth"]).ToShortDateString();
            lblDriverId.Text = row["DriverId"].ToString();
            lblExpirationDate.Text = Convert.ToDateTime(row["ExpirationDate"]).ToShortDateString();

       

            string imagePath = row["ImagePath"].ToString();

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                picPerson.ImageLocation = imagePath;
            }
            else
            {
                if (Convert.ToByte(row["Gendor"]) == 0)
                    picPerson.ImageLocation = @"D:\Projects\DVLD Project\DVLD Project\Resources\Male 512.PNG";
                else
                    picPerson.ImageLocation = @"D:\Projects\DVLD Project\DVLD Project\Resources\Female 512.PNG";
            }
           
        }
        private void frmShowInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            FillAllData();
        }
    }
}
