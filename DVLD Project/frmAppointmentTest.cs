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
    public partial class frmAppointmentTest : Form
    {
        public event Action TestChanges;
        private int _mode;
        private int _Id;
        public event Action TestAdded;
        public frmAppointmentTest(int mode, int id)
        {
            InitializeComponent();
            _mode = mode;
            _Id = id;

        }

        private void ctrLicenseApplicationInfo1_Load(object sender, EventArgs e)
        {

        }

        private void IntializeSuitableTest()
        {
            if (_mode == 1)
            {
                picPagePicture.Image = Properties.Resources.Vision_512;
                lblPageTitle.Text = "Vision Test Appointment";
            }
            else if (_mode == 2)
            {
                picPagePicture.Image = Properties.Resources.Written_Test_512;
                lblPageTitle.Text = "Written Test Appointment";
            }
            else if (_mode == 3)
            {
                picPagePicture.Image = Properties.Resources.driving_test_512;
                lblPageTitle.Text = "Street Test Appointment";
            }
        }
        private void frmAppointmentTest_Load(object sender, EventArgs e)
        {
            IntializeSuitableTest();
            _RefreshHistory();
            ctrLicenseApplicationInfo1.ApplicationId = _Id;
        }
        private int AddApplication()
        {
            int RetakeApplicationId = -1;
            int licenseClassId = ctrLicenseApplicationInfo1.LicenseClassId;


            Applications App = new Applications(ctrLicenseApplicationInfo1.PersonId,
                                                ctrLicenseApplicationInfo1.UserId,
                                                2,
                                                DateTime.Now, (byte)0, DateTime.Now,
                                                Applications.GetRetakeTestFees(),
                                                licenseClassId);

            int result = Applications.AddApplicatoin(App);
            if (result <= 0)
            {
                MessageBox.Show("Lisence retake test application doesn't added try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                MessageBox.Show($"Lisence retake test application added successfully! Your ApplicationId ID = {result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RetakeApplicationId = result;
            }
            return RetakeApplicationId;
        }
        private bool CheckValidationToAddAppointment()
        {
            //check if person have an active appointment
            string TestTypeTitle = "";
            if (_mode == 1) TestTypeTitle = "Vision Test";
            else if (_mode == 2) TestTypeTitle = "Written Test";
            else if (_mode == 3) TestTypeTitle = "Street Test";
            if (Tests.CheckActiveAppointment(_Id,TestTypeTitle)>0)
            {
                MessageBox.Show("Person Already have an active appointment for this test, You cannot add new appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //check if the person already passed the exam
            if (Tests.CheckIfPersonPassTest(Convert.ToInt32(ctrLicenseApplicationInfo1.LDLAId.ToString()), TestTypeTitle))
            {
                MessageBox.Show("Person Already passed this test, You cannot add new appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //check if person fail in the exam
            if (Tests.CheckIfPersonFailTest(Convert.ToInt32(ctrLicenseApplicationInfo1.LDLAId.ToString()), TestTypeTitle))
            {
                RetakeTest();
                return false;
                
            }
            return true;
        }

        private void ShowAddAppointmentPage()
        {
            AddOrEditOrDeleteOrRetakeTest frm = new AddOrEditOrDeleteOrRetakeTest(_mode, false, _Id);
            frm.AppointmentChanged += _RefreshHistory;
            frm.ShowDialog();
        }

        private void TakeTest()
        {
       
            var id = dvgAppointments.CurrentRow.Cells["TestAppointmentId"].Value;
        
            int TestAppointmentId = Convert.ToInt32(id);
   

            if (Applications.CheckIfApplicationIsLocked(TestAppointmentId))
            {
                MessageBox.Show("Person Already passed this test, You cannot take this test again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable dt = Applications.getApplicationDetailsForCard(_Id.ToString());

            if (dt.Rows.Count == 0)
                return;

            DataRow row = dt.Rows[0];
            int UserId = Convert.ToInt32(row["UserId"].ToString());

          

            AddOrEditOrDeleteOrRetakeTest frm =
                new AddOrEditOrDeleteOrRetakeTest(
                    _mode,
                    true,
                    _Id,
                    TestAppointmentId,
                    true,
                    UserId);

            frm.AppointmentChanged += _RefreshHistory;
            frm.AppointmentChanged += ctrLicenseApplicationInfo1.UpdatePassedTest;
            frm.TestAdded += () =>
            {
                _RefreshHistory();
                if (Tests.CheckIfPersonPassAllTests(ctrLicenseApplicationInfo1.LDLAId.ToString()))
                
                TestChanges?.Invoke();

            };

            frm.ShowDialog();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (CheckValidationToAddAppointment())
            {
                ShowAddAppointmentPage();
            }
            //else if (CheckIfPersonWillRetakeTest())
            //{
            //    RetakeTest();
            //}
        }
        //private bool CheckIfPersonWillRetakeTest()
        //{
        //    var id = dvgAppointments.CurrentRow.Cells["TestAppointmentId"].Value;
        //    int TestAppointmentId = Convert.ToInt32(id);
        //    if (Tests.CheckIfPersonFailInTest(TestAppointmentId))
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        private void RetakeTest()
        {
            int RetakeApplicationId = AddApplication();
            if (RetakeApplicationId == -1)
            {
                return; 
            }
            AddOrEditOrDeleteOrRetakeTest frm = new AddOrEditOrDeleteOrRetakeTest((_mode+3),RetakeApplicationId, false, _Id);

            frm.AppointmentChanged += _RefreshHistory;
            frm.ShowDialog();
        }
        private void dvgUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _RefreshHistory();
        }


        public void _RefreshHistory()
        {
            string TestTypeTitle = "";
            if (_mode == 1) TestTypeTitle = "Vision Test";
            else if (_mode == 2) TestTypeTitle = "Written Test";
            else if (_mode == 3) TestTypeTitle = "Street Test";
            dvgAppointments.AutoGenerateColumns = true;
            dvgAppointments.DataSource = Tests.getAppointmentRecords(_Id.ToString(),TestTypeTitle);
            lblRecords.Text = dvgAppointments.Rows.Count.ToString();

        }

        private void dvgAppointments_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dvgAppointments.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dvgAppointments.ClearSelection();
                    dvgAppointments.Rows[hit.RowIndex].Selected = true;
                    dvgAppointments.CurrentCell = dvgAppointments.Rows[hit.RowIndex].Cells[0];
                }
            }
        }

        private void ShowUpdateTestAppointmentPage()
        {
            var id = dvgAppointments.CurrentRow.Cells["TestAppointmentId"].Value;
            int TestAppointmentId = Convert.ToInt32(id);

            if (Applications.CheckIfApplicationIsLocked(TestAppointmentId))
            {
                MessageBox.Show("Person Already passed this test, You cannot edit this appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }
            int RetakeMode = _mode;
            if (Tests.CheckIfApplicationInRetakeMode(TestAppointmentId)){
                RetakeMode += 3;
            }
            AddOrEditOrDeleteOrRetakeTest frm = new AddOrEditOrDeleteOrRetakeTest(RetakeMode, true, _Id, TestAppointmentId); ;
            frm.AppointmentChanged += _RefreshHistory;
            frm.ShowDialog();
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ShowUpdateTestAppointmentPage();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            TakeTest();
        }

        private void btnCloseUserFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
