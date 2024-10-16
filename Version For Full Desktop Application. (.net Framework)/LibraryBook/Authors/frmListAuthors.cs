using DVLD_Buisness;
using LibraryBook.People;
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
//using static DVLD_Buisness.clsAuthor;

namespace LibraryBook.Authors
{
    public partial class frmListAuthors : Form
    {
        private static DataTable _dtAllAuthors;
        public frmListAuthors()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListAuthors_Load(object sender, EventArgs e)
        {
            _dtAllAuthors = clsAuthor.GetAllAuthors();
            dgvListAuthors.DataSource = _dtAllAuthors;
            lblRecordsCount.Text = dgvListAuthors.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
            if (dgvListAuthors.Rows.Count > 0)
            {


                dgvListAuthors.Columns["AuthorID"].HeaderText = "Author ID";
                dgvListAuthors.Columns["AuthorID"].Width = 90;

              

                dgvListAuthors.Columns["FullName"].HeaderText = "Full Name";
                dgvListAuthors.Columns["FullName"].Width = 190;

                

                dgvListAuthors.Columns["BirthDate"].HeaderText = "BirthDate";
                dgvListAuthors.Columns["BirthDate"].Width = 100;
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (cbFilter.Text == "Author ID")
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

            _dtAllAuthors.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvListAuthors.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilter.Text)
            {
                case "Author ID":
                    FilterColumn = "AuthorID";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
               

            }
            if (txtFilterValue.Text.Trim() == "")
                _dtAllAuthors.DefaultView.RowFilter = "";
            else if (FilterColumn == "AuthorID")
                _dtAllAuthors.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllAuthors.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            lblRecordsCount.Text = dgvListAuthors.Rows.Count.ToString();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditAuthor frm = new frmAddEditAuthor();
            frm.ShowDialog();
            frmListAuthors_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AuthorID = (int)dgvListAuthors.CurrentRow.Cells[0].Value;
            frmAddEditAuthor frm = new frmAddEditAuthor(AuthorID);
            frm.ShowDialog();
            frmListAuthors_Load(null, null);
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AuthorID = (int)dgvListAuthors.CurrentRow.Cells[0].Value;
            frmShowAuthorInfo frm = new frmShowAuthorInfo(AuthorID);
            frm.ShowDialog();
            frmListAuthors_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AuthorID = (int)dgvListAuthors.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure do you want to delete Author [" + AuthorID + "]", "Confirm Delete", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (clsAuthor.DeleteAuthor(AuthorID))
            {
                MessageBox.Show("Author Deleted Successfully", "Successful", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                frmListAuthors_Load(null, null);
            }
            else
                MessageBox.Show("Author Was not deleted because it has data linked to it", "Error Delete", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
