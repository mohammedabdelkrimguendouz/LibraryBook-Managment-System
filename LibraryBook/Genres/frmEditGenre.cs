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
using static LibraryBook.Authors.frmAddEditAuthor;

namespace LibraryBook.Genres
{
    public partial class frmEditGenre : Form
    {
        private int _GenreID =-1;
        private clsGenre _Genre;
        public frmEditGenre(int GenreID)
        {
            InitializeComponent();
            _GenreID = GenreID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditGenre_Load(object sender, EventArgs e)
        {
            _Genre=clsGenre.Find(_GenreID);
            if (_Genre == null)
            {
                MessageBox.Show("this form well be closed because No Genre With ID : " + _GenreID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            lblGenreID.Text = _GenreID.ToString();
            txtDescription.Text = _Genre.Description;
            txtGenreName.Text=_Genre.GenreName;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Genre.GenreName = txtGenreName.Text.Trim(); ;
            _Genre.Description=txtDescription.Text.Trim();

            if (_Genre.Save())
            {

                
                
                MessageBox.Show("Data Saved Successfully ", "Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

               
            }
            else
                MessageBox.Show("Data is not Saved Successfully ", "Error ",
               MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtGenreName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtGenreName.Text))
            {
                e.Cancel = true;
                txtGenreName.Focus();
                errorProvider1.SetError(txtGenreName, "This field is required !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtGenreName, null);
            }

            if (_Genre.GenreName!=txtGenreName.Text.Trim() && clsGenre.IsGenreExist(txtGenreName.Text.Trim()))
            {
                e.Cancel = true;
                txtGenreName.Focus();
                errorProvider1.SetError(txtGenreName, "Genre Name already exist !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtGenreName, null);
            }
        }
    }
}
