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
    public partial class AddandDelete_Person : Form
    {
        private int _mode ;
        private int _Id ;
        public ctrPerson MyPersonControl
        {
            get { return this.ctrPerson1; }
        }
        public AddandDelete_Person(int Mode,int Id)
        {
            InitializeComponent();
            _mode = Mode;
            this._Id = Id;
        }
        public AddandDelete_Person(int Mode)
        {
            InitializeComponent();
            _mode = Mode;
        }

        private void IntializeTitle()
        {
            if (_mode == 1)
            {
                lblMainTitle.Text = "Add Person";
                lblPersonIdTex.Visible=false;
                
            }
            else if (_mode == 2)
                lblMainTitle.Text = "Edit Peroson";

            else if(_mode == 3)
                lblMainTitle.Text = "Peroson's Info";
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            IntializeTitle();
            ctrPerson1.PersonId = _Id;
            ctrPerson1.Mode = _mode;
            
            lblPersonId.Text = $"{_Id}";

        }

        private void ctrPerson1_Load(object sender, EventArgs e)
        {

        }
    }
}
