using BusinLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class AddOrEditOrDeleteOrRetakeTest : Form
    {
        private DataTable Record;
        private int _mode;
        private bool _IsEdit;
        private bool _TakeTest = false;
        private int _ApplicationId;
        private int _UserId;
        private int _TestAppointmentId;
        private int _RetakeApplicationID;
        public event Action AppointmentChanged;
        public event Action TestAdded;
        public AddOrEditOrDeleteOrRetakeTest(int mode, bool isEdit, int applicationId)
        {
            InitializeComponent();
            _mode = mode;
            _IsEdit = isEdit;
            _ApplicationId = applicationId;
            IntializeData();
            ApplyMode();
        }
        public AddOrEditOrDeleteOrRetakeTest(int mode, int RetakeApplicationId,bool isEdit, int applicationId)
        {
            InitializeComponent();
            _mode = mode;
            _IsEdit = isEdit;
            _ApplicationId = applicationId;
            IntializeData();
            ApplyMode();
            _RetakeApplicationID = RetakeApplicationId;
        }
        public AddOrEditOrDeleteOrRetakeTest(int mode, bool isEdit, int applicationId,int TestAppointmentId)
        {
            InitializeComponent();
            _mode = mode;
            _IsEdit = isEdit;
            _ApplicationId = applicationId;
            _TestAppointmentId=TestAppointmentId; IntializeData();
            ApplyMode();
        }
        public AddOrEditOrDeleteOrRetakeTest(int mode, bool isEdit, int applicationId, int TestAppointmentId,bool TakeTest, int userId)
        {
            InitializeComponent();
            _mode = mode;
            _IsEdit = isEdit;
            _ApplicationId = applicationId;
            _TestAppointmentId = TestAppointmentId;
            _TakeTest = TakeTest;
            _UserId = userId;
            IntializeData();
            ApplyMode();
        }

        private void lblPageTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnPCClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ApplyMode()
        {
            //Vision Test
            if (_mode == 1)
            {
                picPagePicture.Image = Properties.Resources.Vision_512;
                lblPageTitle.Text = "Vision Test";
                gbRetakeTestInfo.Enabled = false;
            }
            //Written Test
            else if (_mode == 2)
            {
                picPagePicture.Image = Properties.Resources.Written_Test_512;
                lblPageTitle.Text = "Written Test";
                gbRetakeTestInfo.Enabled = false;

            }
            //Street Test
            else if (_mode == 3)
            {
                picPagePicture.Image = Properties.Resources.Vision_512;
                lblPageTitle.Text = "Vision Test";
                gbRetakeTestInfo.Enabled = false;

            }
            //Retake Vision Test 
            else if (_mode == 4)
            {
                picPagePicture.Image = Properties.Resources.Vision_512;
                lblPageTitle.Text = "Retake Vision Test";
            }
            //Retake Written Test
            else if (_mode == 5) 
            {
                picPagePicture.Image = Properties.Resources.Written_Test_512;
                lblPageTitle.Text = "Retake Written Test";

            }
            //Retake Street Test
            else if(_mode == 6)
            {
                picPagePicture.Image = Properties.Resources.driving_test_512;
                lblPageTitle.Text = "Retake Street Test";

            }
        }        

        private void IntializeData()
        {
            if (_TakeTest)
            {
                gbTakeTest.Visible = true;
            }
            else
            { 
                gbTakeTest.Visible = false;
            }
            dateTimePicker1.Value = DateTime.Now.AddMonths(1);

            DataTable dt = Applications.getApplicationDetailsForCard(_ApplicationId.ToString());
            Record = dt;
            DataRow row = dt.Rows[0];
            lblDLAppId.Text = row["LocalDrivingLicenseApplicationId"].ToString();
            lblLicenseClassName.Text = row["ClassName"].ToString();
            lblPerosnName.Text = row["FullName"].ToString();
            if(_mode==1 || _mode == 4)
            {
                lblTestFees.Text =Tests.GetTestTypeFees("Vision Test").ToString();
              lblTrial.Text = (Tests.GetTrialsNumber(Convert.ToInt32(row["PersonId"].ToString()), "Vision Test",Convert.ToInt32(lblDLAppId.Text.ToString()))).ToString();
            }
            else if(_mode == 2 || _mode ==5)
            {
                lblTestFees.Text = Tests.GetTestTypeFees("Written Test").ToString();
                lblTrial.Text = (Tests.GetTrialsNumber(Convert.ToInt32(row["PersonId"].ToString()), "Written Test", Convert.ToInt32(lblDLAppId.Text.ToString()))).ToString();
            }
            else if (_mode == 3 || _mode == 6)
            {
                lblTestFees.Text = Tests.GetTestTypeFees("Street Test").ToString();
               lblTrial.Text = (Tests.GetTrialsNumber(Convert.ToInt32(row["PersonId"].ToString()), "Street Test", Convert.ToInt32(lblDLAppId.Text.ToString()))).ToString();
            }
            if (_mode == 1 || _mode == 2 || _mode == 3)
            {
                lblTotalFees.Text = lblTestFees.Text;
            }
            else
            {
                gbRetakeTestInfo.Enabled = true;
                lblRetakeFees .Text= Applications.GetRetakeTestFees().ToString();
                lblTotalFees.Text = (Convert.ToInt32(lblTestFees.Text.ToString()) + Convert.ToDouble(lblRetakeFees.Text.ToString())).ToString();
            }

        }
        private void AddOrEditOrDeleteOrRetakeTest_Load(object sender, EventArgs e)
        {
            IntializeData();
            ApplyMode();
        }

        private void AddTestAppointment()
        {
            DataRow row = Record.Rows[0];
            int DLAppId = Convert.ToInt32(lblDLAppId.Text.ToString());
            int UserId = Convert.ToInt32(row["UserId"].ToString());
            string TestTypeTitle="";
            if (_mode == 1|| _mode == 4) TestTypeTitle = "Vision Test";
            else if (_mode == 2 || _mode ==5) TestTypeTitle = "Written Test";
            else if (_mode == 3 || _mode ==6) TestTypeTitle = "Street Test";
            int TestTypeId;
            if (_mode == 1 || _mode == 4) TestTypeId = 1;
            else if (_mode == 2 || _mode == 5) TestTypeId = 2;
            else if (_mode == 3 || _mode == 6) TestTypeId = 3;
            else TestTypeId = -1;

                //int TestTypeId = Tests.GetTestTypeId(TestTypeTitle);
                int PaidFees = Tests.GetTestTypeFees(TestTypeTitle);
            int result = Tests.AddTestAppointment(TestTypeId, DLAppId, UserId, PaidFees, false,_RetakeApplicationID);
            if (result <= 0)
            {
                MessageBox.Show("Test Appointment doesn't added try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Test Appointment added successfully! Your Appointment ID = {result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AppointmentChanged?.Invoke();
                this.Close();
            }
        }

        private void UpdateAppointmentDate()
        {
            if(Tests.UpdateAppointmentDate(_TestAppointmentId, dateTimePicker1.Value))
            {
                MessageBox.Show($"Test Appointment edited successfully! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AppointmentChanged?.Invoke();
                this.Close();
            }
            else
            {
                MessageBox.Show("Test Appointment doesn't edited try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void TakeTest()
        {
            bool TestResult = rdbPass.Checked;
            if (Tests.AddTest(_TestAppointmentId,TestResult,txtTestNotes.Text.ToString(),_UserId))
            {
                MessageBox.Show($"Test  added successfully! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AppointmentChanged?.Invoke();
                TestAdded?.Invoke();
                DataRow row = Record.Rows[0];
                lblTrial.Text = (Tests.GetTrialsNumber(Convert.ToInt32(row["PersonId"].ToString()), "Street Test",Convert.ToInt32(lblDLAppId.Text.ToString()))).ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Test  doesn't added try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnPCSave_Click(object sender, EventArgs e)
        {
            if (_TakeTest)
            {
                TakeTest();
            }
            else if (_IsEdit == false)
            {
                AddTestAppointment();
            }
            else if (_IsEdit == true)
            {
                UpdateAppointmentDate();
            }
            //else if ((_mode == 1 || _mode == 2 || _mode == 3) && _IsEdit == false)
            //{
            //    AddTestAppointment();
            //}
            //else if ((_mode == 1 || _mode == 2 || _mode == 3) && _IsEdit == true)
            //{
            //    UpdateAppointmentDate();
            //}
        }

        private void gbTakeTest_Enter(object sender, EventArgs e)
        {

        }
    }
}
