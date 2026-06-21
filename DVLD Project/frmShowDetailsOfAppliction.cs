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
    public partial class frmShowDetailsOfAppliction : Form
    {
        private int _LDLAID;
        public frmShowDetailsOfAppliction(int lDLAID)
        {
            InitializeComponent();
            _LDLAID = lDLAID;
            ctrLicenseApplicationInfo1.ApplicationId = _LDLAID;
        }

        private void btnCloseUserFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowDetailsOfAppliction_Load(object sender, EventArgs e)
        {

        }
    }
}
