using DVLD.Global_Classes;
using DVLD_Buisness;
using DVLD_Buisness.Global_Classes;
using LibraryBook.Properties;
using LibraryBook_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;
//using static DVLD_Buisness.clsBook;

namespace LibraryBook.Books
{
    public partial class frmAddEditBook : Form
    {
        public class BookEventArgs : EventArgs
        {
            public int BookID { get; }
            public BookEventArgs(int BookID)
            {
                this.BookID = BookID;
            }
        }

        public delegate void DataBackEventHandler(object sender, BookEventArgs e);

        public event DataBackEventHandler DataBack;
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;


        private int _BookID = -1;
        private clsBook _Book;

        public frmAddEditBook()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddEditBook(int BookID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _BookID = BookID;
        }

        private void _FillGenresInCompoBox()
        {
            DataTable TableGenres = clsGenre.GetAllGenres();
            foreach (DataRow Row in TableGenres.Rows)
            {
                cbGenres.Items.Add(Row["GenreName"]);
            }
            if(cbGenres.Items.Count > 0) 
                cbGenres.SelectedIndex = 0;
        }

        private void _ResetDefaultValues()
        {
            _FillGenresInCompoBox();
            if (_Mode == enMode.AddNew)
            {
                this.Text = lblTitle.Text = "Add New Book";
                _Book = new clsBook();
            }
            else
            {
                this.Text = lblTitle.Text = "Update Book";
            }


            lblBookID.Text = "[????]";
            txtISBN.Text = "";
            txtTitle.Text = "";
            txtAdditionalDetails.Text = "";
           
            pbCoverImage.ImageLocation = "";
            pbCoverImage.Image = Resources.book_100;


        }

        private void _LoadData()
        {
            _Book = clsBook.Find(_BookID);
            if (_Book == null)
            {
                MessageBox.Show("this form well be closed because No Book With ID : " + _BookID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            lblBookID.Text = _Book.BookID.ToString();
            txtISBN.Text = _Book.ISBN;
            txtTitle.Text = _Book.Title;
            txtAdditionalDetails.Text = _Book.AdditionalDetails;
            cbGenres.SelectedIndex=cbGenres.FindString(_Book.GenreInfo.GenreName);
            nudPagesNumber.Value = _Book.PagesNumber;
            dtpPublicationDate.Value = _Book.PublicationDate;

          

          
            if (_Book.CoverImage != "")
                pbCoverImage.ImageLocation = _Book.CoverImage;
            llRemoveImage.Visible = (pbCoverImage.ImageLocation != "");
        }

        private void frmAddEditBook_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "Choose Image ";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbCoverImage.ImageLocation = openFileDialog1.FileName;
                llRemoveImage.Visible = true;
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbCoverImage.ImageLocation = "";
            pbCoverImage.Image=Resources.book_100;
            llRemoveImage.Visible = false;
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                e.Cancel = true;
                txtTitle.Focus();
                errorProvider1.SetError(txtTitle, "This field is required !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTitle, null);
            }
        }

        private void txtISBN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtISBN.Text.Trim()))
            {
                e.Cancel = true;
                txtISBN.Focus();
                errorProvider1.SetError(txtISBN, "This field is required !");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtISBN, null);
            }

            //validate ISBN
            if (!clsValidation.IsISBN(txtISBN.Text.Trim()))
            {
                e.Cancel = true;
                txtISBN.Focus();
                errorProvider1.SetError(txtISBN, "ISBN Incorrect Format !");
                return ;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtISBN, null);
            }

            // Validate ISBN Exist
            if (_Book.ISBN!=txtISBN.Text.Trim() && clsBook.IsBookExist(txtISBN.Text.Trim()))
            {
                e.Cancel = true;
                txtISBN.Focus();
                errorProvider1.SetError(txtISBN, "ISBN Already Exists !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtISBN, null);
            }

        }

        private bool _HabdelBookCoverImage()
        {
            if (_Book.CoverImage != pbCoverImage.ImageLocation)
            {
                if (_Book.CoverImage != "")
                {
                    try
                    {
                        File.Delete(_Book.CoverImage);
                    }
                    catch (Exception Ex)
                    {
                        return false;
                    }
                }
                if (pbCoverImage.ImageLocation != "")
                {
                    string SourceImageFile = pbCoverImage.ImageLocation;
                    if (clsUtil.CopyImageToImagesBookFolder(ref SourceImageFile))
                    {
                        pbCoverImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;

                    }
                }
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_HabdelBookCoverImage())
                return;


            _Book.ISBN = txtISBN.Text.Trim();
            _Book.GenreID = clsGenre.Find(cbGenres.Text.Trim()).GenreID;
            _Book.PagesNumber = (int)nudPagesNumber.Value;
            _Book.AdditionalDetails = txtAdditionalDetails.Text.Trim();
            _Book.Title = txtTitle.Text.Trim();
            _Book.PublicationDate = dtpPublicationDate.Value;
            
          
            _Book.CoverImage = pbCoverImage.ImageLocation;
            if (_Book.Save())
            {

                this.Text = lblTitle.Text = "Update Book ";
                _Mode = enMode.Update;
                lblBookID.Text = _Book.BookID.ToString();
                MessageBox.Show("Data Saved Successfully ", "Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataBack?.Invoke(this,new BookEventArgs(_Book.BookID));
            }
            else
                MessageBox.Show("Data is not Saved Successfully ", "Error ",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
