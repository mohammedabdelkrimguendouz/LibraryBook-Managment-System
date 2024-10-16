using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBook.People.Controls
{
    public partial class ctrlPersonCardInfoWithFilter : UserControl
    {
        public class PersonSelectedEventArgs : EventArgs
        {
            public int PersonID { get; }
            public PersonSelectedEventArgs(int PersonID)
            {
                this.PersonID = PersonID;
            }
        }

        public event EventHandler<PersonSelectedEventArgs> OnPersonSelected;

        public void RaiseOnPersonSelected(int PersonID)
        {
            RaiseOnPersonSelected(new PersonSelectedEventArgs(PersonID));
        }
        protected virtual void RaiseOnPersonSelected(PersonSelectedEventArgs e)
        {
            OnPersonSelected?.Invoke(this, e);
        }

        private bool _ShowAddNew = true;
        public bool ShowAddNewPerson
        {
            get { return _ShowAddNew; }
            set
            {
                _ShowAddNew = value;
                btnAddNew.Enabled = _ShowAddNew;
            }
        }

        private bool _EnableFilter = true;
        public bool EnableFilter
        {
            get { return _EnableFilter; }
            set
            {
                _EnableFilter = value;
                gbFilters.Enabled = _EnableFilter;
            }
        }

        public int PersonID { get { return ctrlPersonCardInfo1.PersonID; } }

        public clsPerson SelectedPersonInfo { get { return ctrlPersonCardInfo1.SelectedPersonInfo; } }
        public ctrlPersonCardInfoWithFilter()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int PersonID)
        {
            cbFilter.SelectedIndex = cbFilter.FindString("Person ID");
            txtFilterValue.Text = PersonID.ToString();
            _FindNow();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnFind.PerformClick();
            if (cbFilter.Text == "Person ID")
                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFilterValue, null);
            }
        }

        private void _FindNow()
        {
            if (cbFilter.Text == "Person ID")
                ctrlPersonCardInfo1.LoadPersonInfo(Convert.ToInt32(txtFilterValue.Text.Trim()));
            else
                ctrlPersonCardInfo1.LoadPersonInfo(txtFilterValue.Text.Trim());

            if (OnPersonSelected != null && EnableFilter)
                RaiseOnPersonSelected(ctrlPersonCardInfo1.PersonID);
        }
        public void FilterFocus()
        {

            txtFilterValue.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("filed is not valide!, put the mouse over the red icon to see the error", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FindNow();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
        }
        private void DataBackEvent(object sender, frmAddEditPerson.PersonEventArgs e)
        {
            LoadPersonInfo(e.PersonID);
        }
    }
}

