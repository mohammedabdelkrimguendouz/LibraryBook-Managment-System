using DVLD_Buisness.Global_Classes;
using LibraryBook.Properties;
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
using static Guna.UI2.Native.WinApi;

namespace LibraryBook.Books.controls
{
    public partial class ctrlBookCopyInfo : UserControl
    {
        private int _BookCopyID = -1;
        public int BookCopyID { get { return _BookCopyID; } }

        private clsBookCopy _BookCopy;
        public clsBookCopy SelectedBookCopyInfo { get { return _BookCopy; } }
        public ctrlBookCopyInfo()
        {
            InitializeComponent();
        }
        public void LoadBookCopyInfo(int BookCopyID)
        {
            _BookCopy = clsBookCopy.Find(BookCopyID);
            if (_BookCopy == null)
            {
                ResetBookCopyInfo();
                MessageBox.Show("No Book Copy With ID = " + BookCopyID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillBookCopyInfo();

        }
        private void _FillBookCopyInfo()
        {
            ctrlBookCardInfo1.LoadBookInfo(_BookCopy.BookID);
            _BookCopyID = _BookCopy.BookCopyID;
            lblAvailable.Text = (_BookCopy.AvailabilityStatus) ? "Yes" : "No";
            lblBookCopyID.Text=_BookCopy.BookCopyID.ToString();
            lblLanguage.Text = _BookCopy.LanguageInfo.LanguageName;
        }
        public void ResetBookCopyInfo()
        {
            ctrlBookCardInfo1.ResetBookInfo();
            _BookCopyID = -1;
            lblAvailable.Text = "[????]";
            lblBookCopyID.Text = "[????]";
            lblLanguage.Text = "[????]";
        }
    }
}
