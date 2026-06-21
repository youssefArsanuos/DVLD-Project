using BusinLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmShowLicenseInfo : Form
    {
        private int  _LDLAId;
        public frmShowLicenseInfo(int lDLAId)
        {
            InitializeComponent();
            _LDLAId = lDLAId;
        }
        private void FillAllData()
        {
            DataTable dt = Licenses.GetLicenseInfo(Convert.ToInt32(_LDLAId));

            if (dt.Rows.Count == 0)
                return;

            DataRow row = dt.Rows[0];

            lblClassName.Text = row["ClassName"].ToString();
            lblPersonName.Text = row["FullName"].ToString();
            lblLicenseId.Text = row["LicenseId"].ToString();
            lblNationalNo.Text = row["NotionalNo"].ToString();

            if (Convert.ToByte(row["Gendor"]) == 0)
                lblGendor.Text = "Male";
            else
                lblGendor.Text = "Female";

            lblIssueDate.Text = Convert.ToDateTime(row["IssueDate"]).ToShortDateString();
            lblIssueReason.Text = row["IssueReason"].ToString();
            lblNotes.Text = row["Notes"].ToString();

            if (Convert.ToBoolean(row["IsActive"]))
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";

            lblDateOfBirth.Text = Convert.ToDateTime(row["DateOfBirth"]).ToShortDateString();
            lblDriverId.Text = row["DriverId"].ToString();
            lblExpirationDate.Text = Convert.ToDateTime(row["ExpirationDate"]).ToShortDateString();

            if (row["IsReleased"] != DBNull.Value)
            {
                if (Convert.ToBoolean(row["IsReleased"]))
                    lblIsDetained.Text = "No";
                else
                    lblIsDetained.Text = "Yes";
            }
            else
            {
                lblIsDetained.Text = "No";
            }

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
            if (string.IsNullOrWhiteSpace(lblNotes.Text.ToString()))
                lblNotes.Text = "No Notes";
        }
        private void btnClosePeopleFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowLicenseInfo_Load(object sender, EventArgs e)
        {
            FillAllData();
        }
    }
}
