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
    public partial class ctrUserrCard : UserControl
    {
        private int _mode;
        private int _Id;
        private int _UserId;
        private string _UserName;
        private byte _IsActive;
        public ctrUserrCard()
        {
            InitializeComponent();
        }
        public int Mode
        {
            get { return _mode; }
            set
            {
                _mode = value;

                ApplyMode();
            }

        }
        public int UserId
        {
            get { return _UserId; }
            set
            {
                _UserId = value;

            }
        }
        public string UserName
        {
            get { return  _UserName; }
            set
            {
                _UserName = value;

            }
        }
        public byte IsActive
        {
            get { return _IsActive; }
            set
            {
                _IsActive = value;

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
        private void ApplyMode()
        {
            if (_mode == 1)
            {
            }
            else if (_mode == 2)
            {

            }
            else if (_mode == 3)
            {

                ShowUserInfo();
            }
        }
        private void ShowUserInfo()
        {
            ctrPerson1.PersonId = _Id;
            lblUserName.Text = _UserName;
            lblUserId.Text = _UserId.ToString();
            if (IsActive == 1) lblIsActive.Text = "Yes";
            else lblIsActive.Text = "No";
            ctrPerson1.Mode = _mode;

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ctrPerson1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ctrUserrCard_Load(object sender, EventArgs e)
        {

        }
    }
}
