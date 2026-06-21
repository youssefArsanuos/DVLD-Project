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
    public partial class frmTestTypes : Form
    {
        public frmTestTypes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseUserFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvgAppsTypes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dvgTestTypes.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dvgTestTypes.ClearSelection();
                    dvgTestTypes.Rows[hit.RowIndex].Selected = true;
                    dvgTestTypes.CurrentCell = dvgTestTypes.Rows[hit.RowIndex].Cells[0];
                }
            }
        }
        public void _RefreshHistory()
        {
            dvgTestTypes.AutoGenerateColumns = true;
            dvgTestTypes.DataSource = Types.getTestTypes();
            lblTestTypesNumber.Text = dvgTestTypes.Rows.Count.ToString();
        }
        private void frmTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshHistory();
        }

        private void dvgTestTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _RefreshHistory();
        }

        private void ShowUpdateTesttypeForm()
        {
            int TestTypeId = Convert.ToInt32(dvgTestTypes.CurrentRow.Cells["TestTypeId"].Value);

            string TestTypeTitle = dvgTestTypes.CurrentRow.Cells["TestTypeTitle"].Value.ToString();
            string TestTypeDescription = dvgTestTypes.CurrentRow.Cells["TestTypeDescription"].Value.ToString();
            decimal TestTypeFees = Convert.ToDecimal(dvgTestTypes.CurrentRow.Cells["TestTypeFees"].Value);
            frmUpdateTestType frm = new frmUpdateTestType(TestTypeId, TestTypeTitle, TestTypeDescription, TestTypeFees);
            frm.TestEdited += _RefreshHistory;
            frm.ShowDialog();
        }
        private void k_Click(object sender, EventArgs e)
        {
            ShowUpdateTesttypeForm();
        }
    }
}
