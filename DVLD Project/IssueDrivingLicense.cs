using BusinLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{

    public partial class IssueDrivingLicense : Form
    {
        private int _LDLAID;
        public event Action IssueCompleted;

        private int DriverId;
        public IssueDrivingLicense(int lDLAID)
        {
            InitializeComponent();
            _LDLAID = lDLAID;
            ctrLicenseApplicationInfo1.ApplicationId = _LDLAID;

        }

        private void IssueDrivingLicense_Load(object sender, EventArgs e)
        {

        }

        private void btnCloseUserFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
        private void AddDriver()
        {
            int PersonId = ctrLicenseApplicationInfo1.PersonId;
            int CreatedByUserId = ctrLicenseApplicationInfo1.UserId;
            Drivers driver = new Drivers(PersonId, CreatedByUserId);
            DriverId=Drivers.AddDriver(driver);
        }
        private void IssueLicense()
        {
            int PersonId=ctrLicenseApplicationInfo1.PersonId;
            int Id = Drivers.GetDriverIdUsingPersonId(PersonId);
            if (Id == -1)
            {
                AddDriver();
            }
            else
            {
                DriverId = Id;
            }
            DataTable dt = Licenses.GetRequiredDataForAddNewLicense(_LDLAID);
            DataRow row = dt.Rows[0];

            int ApplicationId= Convert.ToInt32(row["ApplicationId"].ToString());
            int LicenseClassId = Convert.ToInt32(row["LicenseClassId"].ToString());
            int ValidityYears = Convert.ToInt32(row["DefaultValidityLength"].ToString());
            decimal Fees = Convert.ToDecimal(row["ClassFees"].ToString());
            byte IssueReason = Convert.ToByte(row["ApplicationTypeID"].ToString());
            int CreatedByUserId = Convert.ToInt32(row["CreatedByUserId"].ToString());
            string Notes=txtTestNotes.Text.ToString();
            Licenses license = new Licenses(ApplicationId, DriverId, LicenseClassId, ValidityYears, Notes, Fees, true, IssueReason, CreatedByUserId,false);
            int LicenseId=Licenses.AddNewLicense(license);
            if (LicenseId <= 0)
            {
                MessageBox.Show("License doesn't added try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"License added successfully! Your License ID = {LicenseId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IssueCompleted?.Invoke();
            }
            this.Close();
        }
        private void btnPCSave_Click(object sender, EventArgs e)
        {
            IssueLicense();
        }

        private void ctrLicenseApplicationInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
