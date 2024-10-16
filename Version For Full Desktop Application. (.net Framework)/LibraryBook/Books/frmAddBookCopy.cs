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
using static LibraryBook.Books.frmAddEditBook;

namespace LibraryBook.Books
{
    public partial class frmAddBookCopy : Form
    {
        private int _BookID = -1;
        public frmAddBookCopy()
        {
            InitializeComponent();
        }
        public frmAddBookCopy(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
        }
        private void _FillLanguagesInCompoBox()
        {
            DataTable TableLanguages = clsLanguage.GetAllLanguages();
            foreach (DataRow Row in TableLanguages.Rows)
            {
                cbLanguages.Items.Add(Row["LanguageName"]);
            }
        }

        private void frmAddBookCopy_Load(object sender, EventArgs e)
        {
            _FillLanguagesInCompoBox();
            cbLanguages.SelectedIndex = cbLanguages.FindString("Arabic");

            if (_BookID == -1)
                return;
            if (!clsBook.IsBookExist(_BookID))
                return;

            
            ctrlBookCardInfoWithFilter1.EnableFilter = false;
            ctrlBookCardInfoWithFilter1.LoadBookInfo(_BookID);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ctrlBookCardInfoWithFilter1.BookID==-1)
            {
                MessageBox.Show("Please Select Book !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            clsBookCopy BookCopy = new clsBookCopy();
            BookCopy.AvailabilityStatus = chkAvailable.Checked;
            BookCopy.BookID = ctrlBookCardInfoWithFilter1.BookID;
            BookCopy.LanguageID = clsLanguage.Find(cbLanguages.Text).ID;

            if (BookCopy.Save())
            {
                lblBookCopyID.Text = BookCopy.BookCopyID.ToString();
                MessageBox.Show("Data Saved Successfully ", "Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data is not Saved Successfully ", "Error ",
               MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
