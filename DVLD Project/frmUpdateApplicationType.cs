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
    public partial class frmUpdateApplicationType : Form
    {
        public event Action EditApp;
        private int _AppId;
        private string _AppTiltle;
        private decimal _AppFees;
        public frmUpdateApplicationType(int AppId,string AppTitle,decimal AppFees)
        {
            InitializeComponent();
            _AppId = AppId;
            _AppTiltle = AppTitle;
            _AppFees = AppFees;
        }

        private void PreparePage()
        {
            lblApplicationId.Text = _AppId.ToString();
            txtAppTitle.Text = _AppTiltle;
            txtAppFees.Text = _AppFees.ToString();
        }
        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            PreparePage();
        }

        private bool CheckValidation()
        {
            if (string.IsNullOrWhiteSpace(txtAppTitle.Text)|| string.IsNullOrWhiteSpace(txtAppFees.Text))
            {
                MessageBox.Show($"Fill All Fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           return true;
        }
        private void EditApplication()
        {
            decimal Fees = Convert.ToDecimal(txtAppFees.Text);
            string Title= txtAppTitle.Text.ToString();
           if( Types.EditApplicationType(_AppId,Title, Fees))
            {
                MessageBox.Show("Application Type edited successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                EditApp?.Invoke();
            }
            else
            {
                MessageBox.Show($"Application Type doesn't edited try again ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        
        private void btnPCSave_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                EditApplication();
            }
        }

        private void btnPCClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
