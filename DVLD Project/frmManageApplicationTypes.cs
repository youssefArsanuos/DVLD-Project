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
    public partial class frmManageApplicationTypes : Form
    {
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _RefreshHistory();
        }

        private void btnCloseUserFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvgAppsTypes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dvgAppsTypes.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dvgAppsTypes.ClearSelection();
                    dvgAppsTypes.Rows[hit.RowIndex].Selected = true;
                    dvgAppsTypes.CurrentCell = dvgAppsTypes.Rows[hit.RowIndex].Cells[0];
                }
            }
        }

        public void _RefreshHistory()
        {
            dvgAppsTypes.AutoGenerateColumns = true;
            dvgAppsTypes.DataSource = Types.getApplicationTypes();
            lblTypesNumber.Text = dvgAppsTypes.Rows.Count.ToString();
        }
        private void dvgAppsTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _RefreshHistory();
        }

        private void ShowUpdateApptypeForm()
        {
            int ApplicationTypeId = Convert.ToInt32(dvgAppsTypes.CurrentRow.Cells["ApplicationTypeId"].Value);

            string ApplicationTypeTitle = dvgAppsTypes.CurrentRow.Cells["ApplicationTypeTitle"].Value.ToString();

            decimal ApplicationTypeFees = Convert.ToDecimal(dvgAppsTypes.CurrentRow.Cells["ApplicationFees"].Value);
            frmUpdateApplicationType frm = new frmUpdateApplicationType(ApplicationTypeId, ApplicationTypeTitle, ApplicationTypeFees);
            frm.EditApp += _RefreshHistory;
            frm.ShowDialog();
        }
        private void k_Click(object sender, EventArgs e)
        {
            ShowUpdateApptypeForm();
        }
    }
}
