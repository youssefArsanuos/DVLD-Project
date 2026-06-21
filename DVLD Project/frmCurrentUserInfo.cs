using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinLayer;
namespace DVLD_Project
{
    public partial class frmCurrentUserInfo : Form
    {
        public frmCurrentUserInfo(User user)
        {
            InitializeComponent();
            ctrUserrCard1.PersonId = user.PersonId;
            ctrUserrCard1.UserId = user.UserId;
            ctrUserrCard1.UserName = user.UserName;
            ctrUserrCard1.IsActive=user.IsActive;
            ctrUserrCard1.Mode = 3;
        }

        private void ctrUserrCard1_Load(object sender, EventArgs e)
        {

        }

        private void btnPCClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCurrentUserInfo_Load(object sender, EventArgs e)
        {

        }

        private void ctrUserrCard1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
