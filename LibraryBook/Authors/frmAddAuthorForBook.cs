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
using static LibraryBook.People.frmAddEditPerson;

namespace LibraryBook.Authors.Controls
{
    public partial class frmAddAuthorForBook : Form
    {
        private int _BookID = -1;
        public frmAddAuthorForBook()
        {
            InitializeComponent();
        }
        public frmAddAuthorForBook(int bookID)
        {
            InitializeComponent();
            _BookID = bookID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int BookID = ctrlBookCardInfoWithFilter1.BookID;
            int AuthoreID = ctrlAuthorCardInfoWithFilter1.AuthorID;
            if (clsBookAuthor.IsBookAuthorExist(BookID,AuthoreID))
            {
                MessageBox.Show("This Author Alraey Exist in this Book", "Error ",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            clsBookAuthor bookAuthor = new clsBookAuthor();
            bookAuthor.AuthorID = AuthoreID;
            bookAuthor.BookID = BookID;

            if (bookAuthor.Save())
            {
                MessageBox.Show("Data Saved Successfully ", "Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data is not Saved Successfully ", "Error ",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcAddAuthorForBook.SelectedTab = tcAddAuthorForBook.TabPages["tpBookInfo"];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlBookCardInfoWithFilter1.BookID == -1)
            {
                MessageBox.Show("Please Select Book !", "Not Access", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                

            pAuthoreInfo.Enabled = true;
            tcAddAuthorForBook.SelectedTab = tcAddAuthorForBook.TabPages["tpAuthorInfo"];
        }

        private void ctrlAuthorCardInfoWithFilter1_OnAuthorSelected(object sender, ctrlAuthorCardInfoWithFilter.AuthorSelectedEventArgs e)
        {
            btnSave.Enabled=(e.AuthorID!=-1);
        }

        private void frmAddAuthorForBook_Load(object sender, EventArgs e)
        {
            if (_BookID == -1)
                return;
            if (!clsBook.IsBookExist(_BookID))
                return;

            ctrlBookCardInfoWithFilter1.EnableFilter = false;
            ctrlBookCardInfoWithFilter1.LoadBookInfo(_BookID);
        }
    }
}
