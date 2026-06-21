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
    
    public partial class frmShowLicenseHistory : Form
    {
        private string _NotionalNo;
        public frmShowLicenseHistory(string NotionalNo)
        {
            InitializeComponent();
            _NotionalNo = NotionalNo;
        }

        private void btnClosePeopleFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Local_Click(object sender, EventArgs e)
        {

        }
        public void _RefreshHistoryLocal()
        {
            dvgLocalLicenses.AutoGenerateColumns = true;
            dvgLocalLicenses.DataSource = Licenses.GetPersonLocalLicenseHistory(_NotionalNo);
            lblRecords.Text = dvgLocalLicenses.Rows.Count.ToString();
        }
        public void _RefreshHistoryInterNational()
        {
            dvgInternationalLiceses.AutoGenerateColumns = true;
            dvgInternationalLiceses.DataSource = Licenses.GetPersonInternationalLicenseHistory(_NotionalNo);
            lblRecords2.Text = dvgInternationalLiceses.Rows.Count.ToString();
        }
        private void LoadPersonData()
        {
            int personId = People.ReturnPersonId(_NotionalNo);
            ctrPerson1.PersonId = personId;
            ctrPerson1.Mode = 3;
        }
        private void frmShowLicenseHistory_Load(object sender, EventArgs e)
        {
            LoadPersonData();
            _RefreshHistoryLocal();
            _RefreshHistoryInterNational();
        }

        private void lblRecor_Click(object sender, EventArgs e)
        {

        }
    }
}
