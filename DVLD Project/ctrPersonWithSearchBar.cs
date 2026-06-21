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
    public partial class ctrPersonWithSearchBar : UserControl
    {
        private int _mode;
        private int _PersonId;
        public int Mode
        {
            get { return _mode; }
            set
            {
                _mode = value;

                ApplyMode();
            }

        }
        public int PersonId
        {
            get { return _PersonId; }
            set
            {
                _PersonId = value;

            }
        }
        public ctrPersonWithSearchBar()
        {
            InitializeComponent();
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
            ctrPerson1.PersonId = _PersonId;

            ctrPerson1.Mode = _mode;

        }
        private void ctrPerson1_Load(object sender, EventArgs e)
        {

        }
        public void PrepareSearchBar()
        {
            cmbUSearchPeoples.Items.Add("PersonId");
            cmbUSearchPeoples.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUSearchPeoples.SelectedItem = "PersonId";
            cmbUSearchPeoples.Enabled = false;


        }
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            AddandDelete_Person frm = new AddandDelete_Person(1);
            frm.ShowDialog();
        }

        private void SearchPerson()
        {
            if (!string.IsNullOrWhiteSpace(txtUSearchPerson.Text))
            {
                int id = Convert.ToInt32(txtUSearchPerson.Text);
                ctrPerson1.PersonId = id;
                ctrPerson1.Mode = 3;
            }
            else
            {
                MessageBox.Show("Enter Person Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            SearchPerson();
        }

        private void txtUSearchPerson_TextChanged(object sender, EventArgs e)
        {
            _PersonId = string.IsNullOrWhiteSpace(txtUSearchPerson.Text)? 0: int.Parse(txtUSearchPerson.Text);

        }

        private void txtUSearchPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
