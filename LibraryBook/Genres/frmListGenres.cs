using LibraryBook.Genres;
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

namespace LibraryBook.Genres
{
    public partial class frmListGenres : Form
    {
        private static DataTable _dtAllGenres;
        public frmListGenres()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListGenres_Load(object sender, EventArgs e)
        {
            _dtAllGenres = clsGenre.GetAllGenres();
            dgvListGenres.DataSource = _dtAllGenres;
            lblRecordsCount.Text = dgvListGenres.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
            if (dgvListGenres.Rows.Count > 0)
            {


                dgvListGenres.Columns["GenreID"].HeaderText = "Genre ID";
                dgvListGenres.Columns["GenreID"].Width = 90;

                dgvListGenres.Columns["GenreName"].HeaderText = "Genre Name";
                dgvListGenres.Columns["GenreName"].Width = 130;



                dgvListGenres.Columns["Description"].HeaderText = "Description";
                dgvListGenres.Columns["Description"].Width = 250;



                dgvListGenres.Columns["NumberOfBooks"].HeaderText = "Nbr.Books";
                dgvListGenres.Columns["NumberOfBooks"].Width = 100;
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Genre ID" || cbFilter.Text=="Nbr.Books")
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

            _dtAllGenres.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvListGenres.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilter.Text)
            {
                case "Genre ID":
                    FilterColumn = "GenreID";
                    break;
                case "Genre Name":
                    FilterColumn = "GenreName";
                    break;
                case "Description":
                    FilterColumn = "Description";
                    break;
                case "Number Of Books":
                    FilterColumn = "NumberOfBooks";
                    break;


            }
            if (txtFilterValue.Text.Trim() == "")
                _dtAllGenres.DefaultView.RowFilter = "";
            else if (FilterColumn == "GenreID" || FilterColumn== "NumberOfBooks")
                _dtAllGenres.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllGenres.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            lblRecordsCount.Text = dgvListGenres.Rows.Count.ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int GenreID = (int)dgvListGenres.CurrentRow.Cells[0].Value;
            frmEditGenre frm = new frmEditGenre(GenreID);
            frm.ShowDialog();
            frmListGenres_Load(null, null);
        }
    }
}
