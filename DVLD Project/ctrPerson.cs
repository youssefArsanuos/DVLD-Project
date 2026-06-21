using BusinLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DVLD_Project
{
    public partial class ctrPerson : UserControl
    {
        private  int _mode;
        private int _Picmode;
        private int _Id;
        private string ImagePath= "D:\\Projects\\DVLD Project\\DVLD Project\\Resources\\Male 512.PNG";
        private bool IsPicExist=false;
        public event Action PersonAdded;

        private void SetDefaultPicture()
        {
            if (!IsPicExist)
            {
                if (rdbM.Checked || (!rdbM.Checked && !rdbF.Checked))
                {
                    picPerson.Image = Properties.Resources.Male_512;
                    ImagePath = "";
                }
                else if (rdbF.Checked)
                {
                    picPerson.Image = Properties.Resources.Female_512;
                    ImagePath = "";
                }
            }
        }

        public int Mode
        {
            get { return _mode; }
            set
            {
                _mode = value;
                _Picmode = value;
                ApplyMode(); 
            }
        }
        public int PersonId
        {
            get { return _Id; }
            set
            {
                _Id = value;
                
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFName.Text) ||
                string.IsNullOrWhiteSpace(txtSName.Text) ||
                string.IsNullOrWhiteSpace(txtTName.Text) ||
                string.IsNullOrWhiteSpace(txtLName.Text) ||
                string.IsNullOrWhiteSpace(txtNationalNo.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill all fields!" ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!rdbM.Checked && !rdbF.Checked)
            {
                MessageBox.Show("Please select gender!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void FromAddToEditButton(int mode)
        {
            if (mode == 1)
            {
                btnPCSetImage.Text = "Add Image";
            }
            else if (mode == 2) {
                btnPCSetImage.Text = "Edit Image";
            }
            
        }

        private  void ApplyMode()
        {
            if (_mode == 1)
            {
            }
            else if (_mode == 2)
            {
                ShowPersonInfo();
            }
            else if (_mode == 3) {
                CardInPersonInfo();
                ShowPersonInfo();
            }
        }

       

        private void ShowPersonInfo()
        {
            DataTable dt = People.GetPerson(_Id);

            if (dt.Rows.Count == 0)
            {
                ResetControl();
                return;
            }

            DataRow row = dt.Rows[0];

            txtFName.Text = row["FirstName"].ToString();
            txtSName.Text = row["SecondName"].ToString();
            txtTName.Text = row["ThirdName"].ToString();
            txtLName.Text = row["LastName"].ToString();
            txtNationalNo.Text = row["NationalNo"].ToString();
            txtPhone.Text = row["Phone"].ToString();
            txtEmail.Text = row["Email"].ToString();
            txtAddress.Text = row["Address"].ToString();

            dateTimePicker1.Value = Convert.ToDateTime(row["DateOfBirth"]);

            byte gendor = Convert.ToByte(row["Gendor"]);
            if (gendor == 0)
                rdbM.Checked = true;
            else
                rdbF.Checked = true;

            cmbCountries.Text = row["CountryName"].ToString();

            string imagePath = row["ImagePath"].ToString();

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                picPerson.ImageLocation = imagePath;
            }
            else
            {
                if (gendor == 0)
                    picPerson.ImageLocation = @"D:\Projects\DVLD Project\DVLD Project\Resources\Male 512.PNG";
                else
                    picPerson.ImageLocation = @"D:\Projects\DVLD Project\DVLD Project\Resources\Female 512.PNG";
            }
        }


        public void CardInPersonInfo()
        {

            txtFName.ReadOnly = true;
            txtSName.ReadOnly = true;
            txtTName.ReadOnly = true;
            txtLName.ReadOnly = true;
            txtNationalNo.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtEmail.ReadOnly = true;

            rdbM.Enabled = false;
            rdbF.Enabled = false;

            dateTimePicker1.Enabled = false;
            cmbCountries.Enabled = false;

            btnPCSetImage.Visible = false;
            btnPCSave.Visible = false;
        }

        
        private void intializeCountries()
        {
            DataTable dt = People.GetCountries();

            cmbCountries.DataSource = dt;
            cmbCountries.DisplayMember = "CountryName";
            cmbCountries.SelectedIndex = cmbCountries.FindStringExact("Egypt");
        }
        public ctrPerson()
        {
            InitializeComponent();
            intializeCountries();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SetDefaultPicture();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void ctrPerson_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
                return;

            intializeCountries();
            //ApplyMode();
            dateTimePicker1.MaxDate = DateTime.Today.AddYears(-18);
            btnPCClose.CausesValidation = false;
            Form frm = this.FindForm();

            if (frm != null)
            {
                frm.AcceptButton = btnPCSave;
            }





        }

        private void txtNationalNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            //{
            //    e.Handled = true;
            //}
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void cmbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdbM_CheckedChanged(object sender, EventArgs e)
        {
            SetDefaultPicture();
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (_mode != 3)
            {
                string nationalNo = txtNationalNo.Text.Trim();

                if (string.IsNullOrEmpty(nationalNo))
                {

                    errorProvider1.SetError(txtNationalNo, "National Number is required!");
                    e.Cancel = true;
                    return;
                }

                if (People.IsNationalNoExist(nationalNo))
                {

                    e.Cancel = true;
                    errorProvider1.SetError(txtNationalNo, "This National Number already exists!");
                }
                else
                {

                    e.Cancel = false;
                    errorProvider1.SetError(txtNationalNo, "");
                }
            }
        }

        private void txtNationalNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_Validated(object sender, EventArgs e)
        {
            
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (_mode != 3)
            {
                string Phone = txtPhone.Text.Trim();

                if (string.IsNullOrEmpty(Phone))
                {

                    errorProvider1.SetError(txtPhone, "Phone Number is required!");
                    e.Cancel = true;
                    return;

                }
                else
                {

                    e.Cancel = false;
                    errorProvider1.SetError(txtPhone, "");
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (_mode != 3)
            {
                string Address = txtAddress.Text.Trim();

                if (string.IsNullOrEmpty(Address))
                {

                    errorProvider1.SetError(txtAddress, "Address is required!");
                    e.Cancel = true;
                    return;

                }
                else
                {

                    e.Cancel = false;
                    errorProvider1.SetError(txtAddress, "");
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (_mode != 3)
            {
                string Email = txtEmail.Text.Trim();

                if (string.IsNullOrEmpty(Email))
                {

                    errorProvider1.SetError(txtEmail, "Email is required!");
                    e.Cancel = true;
                    return;

                }
                else
                {

                    e.Cancel = false;
                    errorProvider1.SetError(txtEmail, "");
                }
            }
        }

        private void txtFName_Validating(object sender, CancelEventArgs e)
        {
            if (_mode != 3)
            {
                string FName = txtFName.Text.Trim();

                if (string.IsNullOrEmpty(FName))
                {

                    errorProvider1.SetError(txtFName, "First Name is required!");
                    e.Cancel = true;
                    return;

                }
                else
                {

                    e.Cancel = false;
                    errorProvider1.SetError(txtFName, "");
                }
            }
        }

        private void txtSName_Validating(object sender, CancelEventArgs e)
        {
            if (_mode != 3)
            {
                string SName = txtSName.Text.Trim();

                if (string.IsNullOrEmpty(SName))
                {

                    errorProvider1.SetError(txtSName, "Second Name is required!");
                    e.Cancel = true;
                    return;

                }
                else
                {

                    e.Cancel = false;
                    errorProvider1.SetError(txtSName, "");
                }
            }
        }

        private void txtTName_Validating(object sender, CancelEventArgs e)
        {
            if (_mode != 3)
            {
                string TName = txtTName.Text.Trim();

                if (string.IsNullOrEmpty(TName))
                {

                    errorProvider1.SetError(txtTName, "Third Name is required!");
                    e.Cancel = true;
                    return;

                }
                else
                {

                    e.Cancel = false;
                    errorProvider1.SetError(txtTName, "");
                }
            }
        }
        private void txtLName_Validating(object sender, CancelEventArgs e)
        {
            if (_mode != 3)
            {
                string LName = txtLName.Text.Trim();

                if (string.IsNullOrEmpty(LName))
                {

                    errorProvider1.SetError(txtLName, "Last Name is required!");
                    e.Cancel = true;
                    return;

                }
                else
                {

                    e.Cancel = false;
                    errorProvider1.SetError(txtLName, "");
                }
            }
        }
        private static string SaveImage(string sourcePath)
        {
            if (string.IsNullOrEmpty(sourcePath))
                return "";

            string folder = Application.StartupPath + @"\Images\People\";

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            string newName = Guid.NewGuid().ToString() + Path.GetExtension(sourcePath);

            string destPath = Path.Combine(folder, newName);

            File.Copy(sourcePath, destPath, true);

            return destPath;
        }

        private void SetImage()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string savedPath = SaveImage(ofd.FileName);
                picPerson.ImageLocation = savedPath;
                ImagePath = savedPath;
            }

            _Picmode = 2;
            btnPCSetImage.Text = "Edit Image";
        }


        public static string ReplaceImage(string oldPath, string newSourcePath)
        {
            if (string.IsNullOrEmpty(newSourcePath))
                return oldPath;

            string folder = Path.GetDirectoryName(oldPath);

            string guidName = Path.GetFileNameWithoutExtension(oldPath);

            string newExt = Path.GetExtension(newSourcePath);

            string newPath = Path.Combine(folder, guidName + newExt);

            if (File.Exists(oldPath))
                File.Delete(oldPath);

            File.Copy(newSourcePath, newPath, true);

            return newPath;
        }
        private void EditImage()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string newPath;

                
                if (string.IsNullOrEmpty(ImagePath))
                {
                    newPath = SaveImage(ofd.FileName);
                }
                else
                {
                    newPath = ReplaceImage(ImagePath, ofd.FileName);
                }

                picPerson.ImageLocation = newPath;
                ImagePath = newPath;
                IsPicExist = true;
            }
        }


        private void btnPCSetImage_Click(object sender, EventArgs e)
        {
            if (_Picmode == 1)
            {
                SetImage();
            }
            else if (_Picmode == 2) 
            {
                EditImage();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPCClose_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
                parentForm.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        
        private People getCardData()
        {
            string Fname= txtFName.Text.ToString();
            string SName=txtSName.Text.ToString();
            string Tname=txtTName.Text.ToString();
            string LaName=txtLName.Text.ToString(); 
            string NationalNo=txtNationalNo.Text.ToString();
            string Address=txtAddress.Text.ToString();
            string phone=txtPhone.Text.ToString();
            string Email=txtEmail.Text.ToString();
            byte gendor=0 ;
            DateTime DateOfBirth = dateTimePicker1.Value;
            int NationalCountryId = Countries.SelectCountryId(cmbCountries.Text.ToString());
            if (rdbM.Checked == true)
                gendor = 0;
            else if(rdbF.Checked == true) 
                gendor = 1;
            People p = new People(Fname,SName, Tname, LaName, NationalNo, Address, phone, Email, ImagePath,gendor, DateOfBirth, NationalCountryId);
            if(_mode==2) p.Id= _Id;
            return p;
        }

        public void ResetControl()
        {
            txtFName.Text = "";
            txtSName.Text = "";
            txtTName.Text = "";
            txtLName.Text = "";
            txtNationalNo.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            SetDefaultPicture();
            rdbM.Checked = false;
            rdbF.Checked = false;
            cmbCountries.SelectedIndex = cmbCountries.FindStringExact("Egypt");
            DateTime today = DateTime.Today;
            dateTimePicker1.MaxDate = today.AddYears(-18);
            dateTimePicker1.Value = dateTimePicker1.MaxDate;
            errorProvider1.Clear();
            picPerson.Image = Properties.Resources.Male_512; 
        }

        private void AddPerson()
        {
          int result=  People.AddPerson(getCardData());
            if(result <= 0)
            {
                MessageBox.Show("Person doesn't added try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Person added successfully! Your ID = {result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetControl();
                PersonAdded?.Invoke();
            }
        }

        private void EditPerson()
        {
            bool result = People.EditPerson(getCardData());
            if (!result)
            {
                MessageBox.Show("Person doesn't edited try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Person edited successfully! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form parentForm = this.FindForm();
                if (parentForm != null)
                    parentForm.Close();
                PersonAdded?.Invoke();
            }
        }
        private void btnPCSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                if (_mode == 1)
                    AddPerson();
                else if (_mode == 2)
                    EditPerson();
            }


            }

        private void txtFNameee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFName_Validating_1(object sender, CancelEventArgs e)
        {
            string FName = txtFName.Text.Trim();

            if (string.IsNullOrEmpty(FName))
            {

                errorProvider1.SetError(txtFName, "First Name is required!");
                e.Cancel = true;
                return;

            }
            else
            {

                e.Cancel = false;
                errorProvider1.SetError(txtFName, "");
            }
        }
    }
}
