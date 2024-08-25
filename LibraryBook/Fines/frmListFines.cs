using LibraryBook.Fines;
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

namespace LibraryFine.Fines
{
    public partial class frmListFines : Form
    {
        private static DataTable _dtAllFines;
        public frmListFines()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListFines_Load(object sender, EventArgs e)
        {
            _dtAllFines = clsFine.GetAllFines();
            dgvListFines.DataSource = _dtAllFines;
            lblRecordsCount.Text = dgvListFines.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
            if (dgvListFines.Rows.Count > 0)
            {

                dgvListFines.Columns["FineID"].HeaderText = "Fine ID";
                dgvListFines.Columns["FineID"].Width = 90;

                dgvListFines.Columns["PersonID"].HeaderText = "Person ID";
                dgvListFines.Columns["PersonID"].Width = 90;

                

                dgvListFines.Columns["LibraryCardNumber"].HeaderText = "Card Number";
                dgvListFines.Columns["LibraryCardNumber"].Width = 240;

                dgvListFines.Columns["FullName"].HeaderText = "Full Name";
                dgvListFines.Columns["FullName"].Width = 140;

                dgvListFines.Columns["FineAmount"].HeaderText = "Fine Amount";
                dgvListFines.Columns["FineAmount"].Width = 120;

                dgvListFines.Columns["Paid"].HeaderText = "Paid";
                dgvListFines.Columns["Paid"].Width = 80;


            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Fine ID" || cbFilter.Text == "Person ID")
                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPaid.Visible = (cbFilter.Text == "Paid");
            if (cbPaid.Visible)
                cbPaid.SelectedIndex = 0;

            txtFilterValue.Visible = (!cbPaid.Visible)&& (cbFilter.Text != "None");
            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }

            _dtAllFines.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvListFines.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";
            switch (cbFilter.Text)
            {
                case "Fine ID":
                    FilterColumn = "FineID";
                    break;
                case "Card Number":
                    FilterColumn = "LibraryCardNumber";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Fine Amount":
                    FilterColumn = "FineAmount";
                    break;

            }
            if (txtFilterValue.Text.Trim() == "")
                _dtAllFines.DefaultView.RowFilter = "";
            else if (FilterColumn == "FineID" || FilterColumn == "PersonID")
                _dtAllFines.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllFines.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            lblRecordsCount.Text = dgvListFines.Rows.Count.ToString();
        }

        private void cbPaid_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterIColumn = "Paid";
            string FilterValue = "";
            switch (cbPaid.Text)
            {
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }
            if (cbPaid.Text == "All")
                _dtAllFines.DefaultView.RowFilter = "";
            else
                _dtAllFines.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterIColumn, FilterValue);
            lblRecordsCount.Text = dgvListFines.Rows.Count.ToString();
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int FineID = (int)dgvListFines.CurrentRow.Cells[0].Value;
            frmShowFineInfo frm=new frmShowFineInfo(FineID);
            frm.ShowDialog();
        }

        


    }
}
