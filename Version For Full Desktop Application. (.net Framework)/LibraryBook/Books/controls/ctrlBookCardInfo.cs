using DVLD_Buisness;
using DVLD_Buisness.Global_Classes;
using LibraryBook.People;
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

namespace LibraryBook.Books.controls
{
    public partial class ctrlBookCardInfo : UserControl
    {
        private int _BookID = -1;
        public int BookID { get { return _BookID; } }

        private clsBook _Book;
        public clsBook SelectedBookInfo { get { return _Book; } }
        public ctrlBookCardInfo()
        {
            InitializeComponent();
        }

        public void LoadBookInfo(int BookID)
        {
            _Book = clsBook.Find(BookID);
            if (_Book == null)
            {
                ResetBookInfo();
                MessageBox.Show("No Book With ID = " + BookID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillBookInfo();

        }
        private void _FillBookInfo()
        {
            _BookID = _Book.BookID;
            lblBookID.Text = _Book.BookID.ToString();
            lblISBN.Text = _Book.ISBN;
            lblTitle.Text = _Book.Title;
            lblGenreName.Text = _Book.GenreInfo.GenreName;
            lblPagesNumber.Text = _Book.PagesNumber.ToString(); ;
            lblPublicationDate.Text = clsFormat.DateToShort( _Book.PublicationDate);
            lblNumberOfAuthors.Text = _Book.NumberOfAuthors.ToString(); ;
            lblNumberOfCopies.Text = _Book.NumberOfCopies.ToString();
           
            lblAdditionalDetails.Text = _Book.AdditionalDetails;
            pbCoverImage.ImageLocation=_Book.CoverImage;
            if (pbCoverImage.ImageLocation == "")
                pbCoverImage.Image = Resources.book_100;

            

            llEditBookInfo.Enabled = true;
        }

        public void LoadBookInfo(string ISBN)
        {
            _Book = clsBook.Find(ISBN);
            if (_Book == null)
            {
                ResetBookInfo();
                MessageBox.Show("No Book With ISBN = " + ISBN, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillBookInfo();
        }

        public void ResetBookInfo()
        {
            _BookID = -1;
            lblBookID.Text = "[????]";
            lblISBN.Text = "[????]";
            lblTitle.Text = "[????]";
            lblGenreName.Text = "[????]";
            lblPagesNumber.Text = "[????]";
            lblPublicationDate.Text = "[????]";
            lblNumberOfAuthors.Text = "[????]";
            lblNumberOfCopies.Text = "[????]";

            lblAdditionalDetails.Text = "[????]";
            pbCoverImage.ImageLocation ="";
            
           pbCoverImage.Image = Resources.book_100;

            llEditBookInfo.Enabled = false;
        }

      

        private void llEditBookInfo_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditBook frm = new frmAddEditBook(_BookID);
            frm.ShowDialog();
            LoadBookInfo(_BookID);
        }
    }
}
