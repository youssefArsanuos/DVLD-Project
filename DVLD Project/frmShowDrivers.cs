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
    public partial class frmShowDrivers : Form
    {
        public frmShowDrivers()
        {
            InitializeComponent();
        }

        private void btnCloseUserFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void _RefreshHistory()
        {
            dvgDrivers.AutoGenerateColumns = true;
            dvgDrivers.DataSource = Drivers.GetAllDrivers();
            lblRecords.Text = dvgDrivers.Rows.Count.ToString();
        }
        private void frmShowDrivers_Load(object sender, EventArgs e)
        {
            _RefreshHistory();
            fillSearchColumns();
        }
        private void fillSearchColumns()
        {
            cmbSearchDrivers.Items.Clear();

            foreach (DataGridViewColumn col in dvgDrivers.Columns)
            {
                cmbSearchDrivers.Items.Add(col.Name);
            }

        }
        private void dvgDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _RefreshHistory();
            
        }

        private void Search()
        {
            string search = txtSearchDrivers.Text.Trim();
            string col = cmbSearchDrivers.Text;

            DataView dv = Drivers.GetAllDrivers().DefaultView;

            if (string.IsNullOrEmpty(search))
            {
                dv.RowFilter = "";
            }
            else
            {
                if (col == "DriverId" ||
                    col == "PersonId" ||
                    col == "ActiveLicenses")
                {
                    if (int.TryParse(search, out int num))
                        dv.RowFilter = $"{col} = {num}";
                    else
                        dv.RowFilter = "1 = 0";
                }
                else
                {
                    dv.RowFilter = $"CONVERT([{col}], System.String) LIKE '%{search}%'";
                }
            }

            dvgDrivers.DataSource = dv;
            lblRecords.Text = dvgDrivers.Rows.Count.ToString();
        }

        private void txtSearchDrivers_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void lblRecor_Click(object sender, EventArgs e)
        {

        }

        private void lblRecords_Click(object sender, EventArgs e)
        {

        }

        private void cmbSearchDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
