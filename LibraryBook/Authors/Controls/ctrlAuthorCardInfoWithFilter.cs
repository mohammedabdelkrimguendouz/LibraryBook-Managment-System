using DVLD_Buisness;
using LibraryBook.People;
using LibraryBook.People.Controls;
using LibraryBook_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBook.Authors.Controls
{
    public partial class ctrlAuthorCardInfoWithFilter : UserControl
    {
        public class AuthorSelectedEventArgs : EventArgs
        {
            public int AuthorID { get; }
            public AuthorSelectedEventArgs(int AuthorID)
            {
                this.AuthorID = AuthorID;
            }
        }

        public event EventHandler<AuthorSelectedEventArgs> OnAuthorSelected;

        public void RaiseOnAuthorSelected(int AuthorID)
        {
            RaiseOnAuthorSelected(new AuthorSelectedEventArgs(AuthorID));
        }
        protected virtual void RaiseOnAuthorSelected(AuthorSelectedEventArgs e)
        {
            OnAuthorSelected?.Invoke(this, e);
        }

        private bool _ShowAddNew = true;
        public bool ShowAddNewAuthor
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

        public int AuthorID { get { return ctrlAuthorCardInfo1.AuthorID; } }

        public clsAuthor SelectedAuthorInfo { get { return ctrlAuthorCardInfo1.SelectedAuthorInfo; } }
        public ctrlAuthorCardInfoWithFilter()
        {
            InitializeComponent();
        }

        public void LoadAuthorInfo(int AuthorID)
        {
            txtFilterValue.Text = AuthorID.ToString();
            _FindNow();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnFind.PerformClick();
           
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
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
            
            ctrlAuthorCardInfo1.LoadAuthorInfo(Convert.ToInt32(txtFilterValue.Text.Trim()));
            

            if (OnAuthorSelected != null && EnableFilter)
                RaiseOnAuthorSelected(ctrlAuthorCardInfo1.AuthorID);
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
            frmAddEditAuthor frm = new frmAddEditAuthor();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
        }
        private void DataBackEvent(object sender, frmAddEditAuthor.AuthorEventArgs e)
        {
            
            txtFilterValue.Text = e.AuthorID.ToString();
            ctrlAuthorCardInfo1.LoadAuthorInfo(e.AuthorID);
        }
    }
}
