using DVLD_Buisness;
using LibraryBook.Authors.Controls;
using LibraryBook.Reservations;
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


namespace LibraryBook.Books
{
    public partial class frmListBooks : Form
    {
        private static DataTable _dtAllBooks;
        public frmListBooks()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListBooks_Load(object sender, EventArgs e)
        {
            _dtAllBooks = clsBook.GetAllBooks();
            dgvListBooks.DataSource = _dtAllBooks;
            lblRecordsCount.Text = dgvListBooks.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
            if (dgvListBooks.Rows.Count > 0)
            {
               

                dgvListBooks.Columns["BookID"].HeaderText = "Book ID";
                dgvListBooks.Columns["BookID"].Width = 90;

                dgvListBooks.Columns["ISBN"].HeaderText = "ISBN";
                dgvListBooks.Columns["ISBN"].Width = 130;

                dgvListBooks.Columns["Title"].HeaderText = "Title";
                dgvListBooks.Columns["Title"].Width = 160;

                dgvListBooks.Columns["GenreName"].HeaderText = "Genre Name";
                dgvListBooks.Columns["GenreName"].Width = 100;

                dgvListBooks.Columns["NumberOfAuthors"].HeaderText = "Nbr.Authors";
                dgvListBooks.Columns["NumberOfAuthors"].Width = 100;

                dgvListBooks.Columns["NumberOfCopies"].HeaderText = "Nbr.Copies";
                dgvListBooks.Columns["NumberOfCopies"].Width = 100;

                
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Book ID" || cbFilter.Text== "Nbr.Copies" || cbFilter.Text=="Nbr.Authors")
                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilter.Text != "None");
            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }

            _dtAllBooks.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvListBooks.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
         
            string FilterColumn = "";
            switch (cbFilter.Text)
            {
                case "Book ID":
                    FilterColumn = "BookID";
                    break;
                case "ISBN":
                    FilterColumn = "ISBN";
                    break;
                case "Genre Name":
                    FilterColumn = "GenreName";
                    break;
                case "Title":
                    FilterColumn = "Title";
                    break;
                case "Number Of Authors":
                    FilterColumn = "NumberOfAuthors";
                    break;
                case "Number Of Copies":
                    FilterColumn = "NumberOfCopies";
                    break;

            }
            if (txtFilterValue.Text.Trim() == "")
                _dtAllBooks.DefaultView.RowFilter = "";
            else if (FilterColumn == "BookID"|| FilterColumn== "NumberOfAuthors"||FilterColumn== "NumberOfBooks")
                _dtAllBooks.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllBooks.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            lblRecordsCount.Text = dgvListBooks.Rows.Count.ToString();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditBook frm=new frmAddEditBook();
            frm.ShowDialog();
            frmListBooks_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BookID = (int)dgvListBooks.CurrentRow.Cells[0].Value;
            frmAddEditBook frm = new frmAddEditBook(BookID);
            frm.ShowDialog();
            frmListBooks_Load(null, null);
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BookID = (int)dgvListBooks.CurrentRow.Cells[0].Value;
            frmShowBookInfo frm = new frmShowBookInfo(BookID);
            frm.ShowDialog();
            frmListBooks_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BookID = (int)dgvListBooks.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure do you want to delete Book [" + BookID + "]", "Confirm Delete", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (clsBook.DeleteBook(BookID))
            {
                MessageBox.Show("Book Deleted Successfully", "Successful", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                frmListBooks_Load(null, null);
            }
            else
                MessageBox.Show("Book Was not deleted because it has data linked to it", "Error Delete", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void addCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BookID = (int)dgvListBooks.CurrentRow.Cells[0].Value;
            frmAddBookCopy frm =new frmAddBookCopy(BookID);
            frm.ShowDialog();
            frmListBooks_Load(null, null);
        }

        private void addAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BookID = (int)dgvListBooks.CurrentRow.Cells[0].Value;
            frmAddAuthorForBook frm = new frmAddAuthorForBook(BookID);
            frm.ShowDialog();
            frmListBooks_Load(null, null);
        }

        private void borrowingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BookID = (int)dgvListBooks.CurrentRow.Cells[0].Value;
            frmAddEditBorrowingRecord frm = new frmAddEditBorrowingRecord();
            frm.ctrlBookCardInfoWithFilter1.EnableFilter = false;
            frm.ctrlBookCardInfoWithFilter1.LoadBookInfo(BookID);
            frm.ShowDialog();
        }

        private void reserveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BookID = (int)dgvListBooks.CurrentRow.Cells[0].Value;
            frmAddReservation frm = new frmAddReservation(BookID);
            frm.ShowDialog();
        }
    }
}
