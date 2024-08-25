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

namespace LibraryBook.Books.controls
{
    public partial class ctrlBookCardInfoWithFilter : UserControl
    {
        public class BookSelectedEventArgs : EventArgs
        {
            public int BookID { get; }
            public BookSelectedEventArgs(int BookID)
            {
                this.BookID = BookID;
            }
        }

        public event EventHandler<BookSelectedEventArgs> OnBookSelected;

        public void RaiseOnBookSelected(int BookID)
        {
            RaiseOnBookSelected(new BookSelectedEventArgs(BookID));
        }
        protected virtual void RaiseOnBookSelected(BookSelectedEventArgs e)
        {
            OnBookSelected?.Invoke(this, e);
        }

        private bool _ShowAddNew = true;
        public bool ShowAddNewBook
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

        public int BookID { get { return ctrlBookCardInfo1.BookID; } }

        public clsBook SelectedBookInfo { get { return ctrlBookCardInfo1.SelectedBookInfo; } }
        public ctrlBookCardInfoWithFilter()
        {
            InitializeComponent();
        }

        public void LoadBookInfo(int BookID)
        {
            cbFilter.SelectedIndex = cbFilter.FindString("Book ID");
            txtFilterValue.Text = BookID.ToString();
            _FindNow();
        }
        public void LoadBookInfo(string ISBN)
        {
            cbFilter.SelectedIndex = cbFilter.FindString("ISBN");
            txtFilterValue.Text = ISBN;
            _FindNow();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnFind.PerformClick();
            if (cbFilter.Text == "Book ID")
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
            if (cbFilter.Text == "Book ID")
                ctrlBookCardInfo1.LoadBookInfo(Convert.ToInt32(txtFilterValue.Text.Trim()));
            else
                ctrlBookCardInfo1.LoadBookInfo(txtFilterValue.Text.Trim());

            if (OnBookSelected != null && EnableFilter)
                RaiseOnBookSelected(ctrlBookCardInfo1.BookID);
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
            frmAddEditBook frm = new frmAddEditBook();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
        }
        private void DataBackEvent(object sender, frmAddEditBook.BookEventArgs e)
        {
            cbFilter.SelectedIndex = cbFilter.FindString("Book ID");
            txtFilterValue.Text = e.BookID.ToString();
            ctrlBookCardInfo1.LoadBookInfo(e.BookID);
        }
    }
}
