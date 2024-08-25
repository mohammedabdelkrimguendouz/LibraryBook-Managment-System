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

namespace LibraryBook.Book_Copies
{
    public partial class ctrlListCopiesForBook : UserControl
    {
        private DataTable _dtAllBookCopiesForBook=new DataTable();
        private int _BookID = -1;
        public ctrlListCopiesForBook()
        {
            InitializeComponent();
        }

        public  void LoadCopiesForBook(int BookID)
        {
            _BookID = BookID;
            _dtAllBookCopiesForBook =clsBookCopy.GetAllCopiesForBook(BookID);
            dgvListCopiesForBook.DataSource = _dtAllBookCopiesForBook;
            lblRecordsCount.Text = dgvListCopiesForBook.Rows.Count.ToString();
            
            if (dgvListCopiesForBook.Rows.Count > 0)
            {


                dgvListCopiesForBook.Columns["BookCopyID"].HeaderText = "B.Copy ID";
               // dgvListCopiesForBook.Columns["BookCopyID"].Width = 100;

                dgvListCopiesForBook.Columns["LanguageName"].HeaderText = "Language";
                //dgvListCopiesForBook.Columns["LanguageName"].Width = 140;



                dgvListCopiesForBook.Columns["AvailabilityStatus"].HeaderText = "Available";
               // dgvListCopiesForBook.Columns["AvailabilityStatus"].Width = 90;



                
            }
        }

        public void Clear()
        {
            if (_dtAllBookCopiesForBook.Rows.Count > 0)
                _dtAllBookCopiesForBook.Clear();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BookCopyID = (int)dgvListCopiesForBook.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure do you want to delete Book Copy [" + BookCopyID + "]", "Confirm Delete", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (clsBookCopy.DeleteBookCopy(BookCopyID))
            {
                MessageBox.Show(" Deleted Successfully", "Successful", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                LoadCopiesForBook(_BookID);
            }
            else
                MessageBox.Show(" Was not deleted because it has data linked to it", "Error Delete", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void cmsListCopiesForBook_Opening(object sender, CancelEventArgs e)
        {
            deleteToolStripMenuItem.Enabled = _dtAllBookCopiesForBook.Rows.Count > 0;
        }
    }
}
