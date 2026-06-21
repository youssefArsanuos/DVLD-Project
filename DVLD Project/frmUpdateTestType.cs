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

    public partial class frmUpdateTestType : Form
    {
        public event Action TestEdited;

        private int _TestId;
        private string _TestTiltle;
        private string _TestDescription;
        private decimal _TestFees;
        public frmUpdateTestType(int TestId,string TestTitle,string TestDescription,decimal TestFees)
        {
            InitializeComponent();
            this._TestId = TestId;
            this._TestDescription = TestDescription;
            this._TestFees=TestFees;
            this._TestTiltle = TestTitle;
        }

        private void PreparePage()
        {

            lblTestId.Text = _TestId.ToString();
            txtTestTitle.Text = _TestTiltle;
            txtTestDescription.Text = _TestDescription;
            txtTestFees.Text = _TestFees.ToString();
        }
        private void btnPCClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckValidation()
        {
            if (string.IsNullOrWhiteSpace(txtTestTitle.Text) || string.IsNullOrWhiteSpace(txtTestFees.Text) || string.IsNullOrWhiteSpace(txtTestDescription.Text))
            {
                MessageBox.Show($"Fill All Fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void EditTest()
        {
            decimal Fees = Convert.ToDecimal(txtTestFees.Text);
            string Title = txtTestTitle.Text.ToString();
            string Description = txtTestDescription.Text.ToString();
            if (Types.EditTestType(_TestId, Title, Fees, Description))
            {
                MessageBox.Show("Test Type edited successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                TestEdited?.Invoke();
            }
            else
            {
                MessageBox.Show($"Test Type doesn't edited try again ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnPCSave_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                EditTest();
            }
        }

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            PreparePage();
        }
    }
}
