using LibraryBook.Authors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBook.Books
{
    public partial class frmShowBookInfo : Form
    {
        private int _BookID = -1;
        public frmShowBookInfo(int bookID)
        {
            InitializeComponent();
            _BookID = bookID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowBookInfo_Load(object sender, EventArgs e)
        {
           ctrlBookCardInfo1.LoadBookInfo(_BookID);
           ctrlListAuthorsForBook1.LoadAuthorsForBook(_BookID);
           ctrlListCopiesForBook1.LoadCopiesForBook(_BookID);
           
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcBookInfo.SelectedTab = tcBookInfo.TabPages["tpAuthorsAndCopies"];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcBookInfo.SelectedTab = tcBookInfo.TabPages["tpBookInfo"];
        }

        private void btnAddBookCopy_Click(object sender, EventArgs e)
        {
            frmAddBookCopy frm=new frmAddBookCopy(_BookID);
            frm.ShowDialog();
            ctrlListCopiesForBook1.LoadCopiesForBook(_BookID);
        }

        private void btnAddAuthorForBook_Click(object sender, EventArgs e)
        {
            frmAddAuthorForBook frm = new frmAddAuthorForBook(_BookID);
            frm.ShowDialog();
            ctrlListAuthorsForBook1.LoadAuthorsForBook(_BookID);
        }
    }
}
