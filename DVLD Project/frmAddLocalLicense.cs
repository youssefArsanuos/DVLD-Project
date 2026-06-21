using BusinLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace DVLD_Project
{
    public partial class frmAddLocalLicense : Form
    {
        private User user;
        public event Action ApplicationAdded;
        public frmAddLocalLicense(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void btnPCClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void intializeClasses()
        {
  
            cmbLicenseClass.DataSource = Applications.GetLicenseClasses();
            cmbLicenseClass.DisplayMember = "ClassName";
            cmbLicenseClass.ValueMember = "LicenseClassId";


            //cmbLicenseClass.SelectedIndex = cmbLicenseClass.FindStringExact("");
        }
        
        private void AddLocalLicense_Load(object sender, EventArgs e)
        {
            intializeClasses();
            lblAppDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblUserCreat.Text = user.UserName;
            lblAppFees.Text=Applications.GetNewLocalDrivingLicenseFees().ToString();
            ctrPersonWithSearchBar1.PrepareSearchBar(); 
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ctrPersonWithSearchBar1.PersonId==0)
            {

                MessageBox.Show("Enter Person Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //check if person exist in the system
            if (!People.CheckIfPersonExist(ctrPersonWithSearchBar1.PersonId.ToString()))
            {
                MessageBox.Show("This Person doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            tabcontrol1.SelectedIndex = 1;
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabcontrol1.SelectedIndex = 0;
        }

        private bool CheckValdation()
        {
            int licenseClassId = Convert.ToInt32(cmbLicenseClass.SelectedValue);
            int PersonId = ctrPersonWithSearchBar1.PersonId;

            //check if search bar is empty
            if (ctrPersonWithSearchBar1.PersonId == 0)
                {

                    MessageBox.Show("Enter Person Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //check if person exist in the system
                if (!People.CheckIfPersonExist(ctrPersonWithSearchBar1.PersonId.ToString()))
                {
                    MessageBox.Show("This Person doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //check if person have the same application
                if(Applications.CheckIfApplicationExist(ctrPersonWithSearchBar1.PersonId, 1, licenseClassId))
                {
                MessageBox.Show("This person previously submitted this request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                }
            //check if a person has a license from same class
            if (Licenses.CheckExistActiveLicense(PersonId, licenseClassId))
            {
                MessageBox.Show("This person already have an active license form this class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void AddApplication()
        {
            int licenseClassId = Convert.ToInt32(cmbLicenseClass.SelectedValue);


            Applications App = new Applications(ctrPersonWithSearchBar1.PersonId,
                                                user.UserId,
                                                1,
                                                DateTime.Now,(byte)0,DateTime.Now,
                                                Applications.GetNewLocalDrivingLicenseFees(),
                                                licenseClassId);

            int result = Applications.AddApplicatoin(App);
            if (result <= 0)
            {
                MessageBox.Show("Lisence application doesn't added try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Lisence application added successfully! Your ApplicationId ID = {result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               ApplicationAdded?.Invoke();
            }
            this.Close();
        }
        private void btnPCSave_Click(object sender, EventArgs e)
        {
            if (CheckValdation())
            {
                AddApplication();
            }
        }

        private void cmbLicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

    

        
    }
}
