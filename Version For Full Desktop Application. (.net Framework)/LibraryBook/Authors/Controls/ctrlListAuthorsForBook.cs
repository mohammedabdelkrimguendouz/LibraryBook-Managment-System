using DVLD_Buisness;
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
    public partial class ctrlListAuthorsForBook : UserControl
    {
        private DataTable _dtAllAuthorsForBook = new DataTable();
        private int _BookID = -1;
        public ctrlListAuthorsForBook()
        {
            InitializeComponent();
        }

        public void LoadAuthorsForBook(int BookID)
        {
            _BookID = BookID;
            _dtAllAuthorsForBook = clsBookAuthor.GetAllAuthorsForBook(BookID);
            dgvListAuthorsForBook.DataSource = _dtAllAuthorsForBook;
            lblRecordsCount.Text = dgvListAuthorsForBook.Rows.Count.ToString();

            if (dgvListAuthorsForBook.Rows.Count > 0)
            {


                dgvListAuthorsForBook.Columns["BookAuthorID"].HeaderText = "B.Author ID";
                //dgvListAuthorsForBook.Columns["BookAuthorID"].Width = 100;

                dgvListAuthorsForBook.Columns["AuthorID"].HeaderText = "Author ID";
                //dgvListAuthorsForBook.Columns["AuthorID"].Width = 100;



                dgvListAuthorsForBook.Columns["FullName"].HeaderText = "Full Name";
               // dgvListAuthorsForBook.Columns["FullName"].Width = 140;




            }
        }

        public void Clear()
        {
            if (_dtAllAuthorsForBook.Rows.Count > 0)
                _dtAllAuthorsForBook.Clear();
        }

       

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BookAuthorID = (int)dgvListAuthorsForBook.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure do you want to delete Book Author [" + BookAuthorID + "]", "Confirm Delete", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (clsBookAuthor.DeleteBookAuthor(BookAuthorID))
            {
                MessageBox.Show(" Deleted Successfully", "Successful", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                LoadAuthorsForBook(_BookID);
            }
            else
                MessageBox.Show(" Was not deleted because it has data linked to it", "Error Delete", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void cmsListAuthorsForBook_Opening(object sender, CancelEventArgs e)
        {
            showAuthorInfoToolStripMenuItem.Enabled= _dtAllAuthorsForBook.Rows.Count > 0;
            deleteToolStripMenuItem.Enabled = _dtAllAuthorsForBook.Rows.Count > 0;
        }

        private void showAuthorInfoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int AuthorID = (int)dgvListAuthorsForBook.CurrentRow.Cells[1].Value;
            frmShowAuthorInfo frm = new frmShowAuthorInfo(AuthorID);
            frm.ShowDialog();
            LoadAuthorsForBook(_BookID);
        }
    }
}
