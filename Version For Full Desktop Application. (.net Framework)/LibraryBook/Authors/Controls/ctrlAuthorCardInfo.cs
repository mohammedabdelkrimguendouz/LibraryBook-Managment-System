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

namespace LibraryBook.Authors.Controls
{
    public partial class ctrlAuthorCardInfo : UserControl
    {
        private int _AuthorID = -1;
        public int AuthorID { get { return _AuthorID; } }

        private clsAuthor _Author;
        public clsAuthor SelectedAuthorInfo { get { return _Author; } }
        public ctrlAuthorCardInfo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void LoadAuthorInfo(int AuthorID)
        {
            _Author = clsAuthor.Find(AuthorID);
            if (_Author == null)
            {
                ResetAuthorInfo();
                MessageBox.Show("No Author With ID = " + AuthorID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillAuthorInfo();

        }
        private void _FillAuthorInfo()
        {
            _AuthorID = _Author.AuthorID;
            lblAuthorID.Text = _Author.AuthorID.ToString();
            lblCountry.Text = _Author.NationalityCountryInfo.CountryName;
            lblDeathDate.Text = (_Author.DeathDate == null) ? "Not Yet" : clsFormat.DateToShort(_Author.DeathDate.Value);
            lblFullName.Text = _Author.FullName;
            lblBirthDate.Text = clsFormat.DateToShort(_Author.BirthDate);
            lblNumberOfBooks.Text = _Author.NumberOfBooks.ToString();

            llEditInfo.Enabled = true;
        }

        public void ResetAuthorInfo()
        {
            lblAuthorID.Text = "[????]";
            lblCountry.Text = "[????]";
            lblDeathDate.Text = "[????]";
            lblFullName.Text = "[????]";
            lblBirthDate.Text = "[????]";
            lblNumberOfBooks.Text= "[????]";
            llEditInfo.Enabled = false;
            
            _AuthorID = -1;
        }

        private void llEditInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditAuthor frm = new frmAddEditAuthor(_AuthorID);
            frm.ShowDialog();
            LoadAuthorInfo(_AuthorID);
        }
    }
}
