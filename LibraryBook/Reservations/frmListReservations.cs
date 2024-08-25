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
using static DVLD_Buisness.clsPerson;

namespace LibraryBook.Reservations
{
    public partial class frmListReservations : Form
    {
        private static DataTable _dtAllReservations;
        public frmListReservations()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListReservations_Load(object sender, EventArgs e)
        {

            
            _dtAllReservations = clsReservation.GetAllReservations();
            dgvListReservations.DataSource = _dtAllReservations;
            lblRecordsCount.Text = dgvListReservations.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
            if (dgvListReservations.Rows.Count > 0)
            {


                dgvListReservations.Columns["ReservationID"].HeaderText = "Reservation ID";
                dgvListReservations.Columns["ReservationID"].Width = 80;

                dgvListReservations.Columns["PersonID"].HeaderText = "Person ID";
                dgvListReservations.Columns["PersonID"].Width = 80;

                dgvListReservations.Columns["LibraryCardNumber"].HeaderText = "Card Number";
                dgvListReservations.Columns["LibraryCardNumber"].Width = 260;

                dgvListReservations.Columns["FullName"].HeaderText = "Full Name";
                dgvListReservations.Columns["FullName"].Width = 200;

                dgvListReservations.Columns["BookID"].HeaderText = "Book ID";
                dgvListReservations.Columns["BookID"].Width = 80;

                dgvListReservations.Columns["ISBN"].HeaderText = "ISBN";
                dgvListReservations.Columns["ISBN"].Width = 140;

                dgvListReservations.Columns["Title"].HeaderText = "Title";
                dgvListReservations.Columns["Title"].Width = 140;


                dgvListReservations.Columns["LanguageName"].HeaderText = "Language";
                dgvListReservations.Columns["LanguageName"].Width = 100;

               
                dgvListReservations.Columns["ReservationDate"].HeaderText = "Date";
                dgvListReservations.Columns["ReservationDate"].Width = 100;

                dgvListReservations.Columns["ReservationStatus"].HeaderText = "Status";
                dgvListReservations.Columns["ReservationStatus"].Width = 60;



            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Book ID" || cbFilter.Text == "Reservation ID" || cbFilter.Text == "Person ID")
                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbStatus.Visible= (cbFilter.Text == "Status");
            if (cbStatus.Visible )
                cbStatus.SelectedIndex = 0;

            txtFilterValue.Visible = (!cbStatus.Visible)&& (cbFilter.Text != "None");
            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }

            _dtAllReservations.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvListReservations.Rows.Count.ToString();
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
                case "Reservation ID":
                    FilterColumn = "ReservationID";
                    break;
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "Language":
                    FilterColumn = "LanguageName";
                    break;
                case "Title":
                    FilterColumn = "Title";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Card Number":
                    FilterColumn = "LibraryCardNumber";
                    break;
                    
            }
            if (txtFilterValue.Text.Trim() == "")
                _dtAllReservations.DefaultView.RowFilter = "";
            else if (FilterColumn == "BookID" || FilterColumn == "ReservationID" || FilterColumn == "PersonID")
                _dtAllReservations.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllReservations.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            lblRecordsCount.Text = dgvListReservations.Rows.Count.ToString();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterIColumn = "Ststus";
            string FilterValue = cbStatus.Text.Trim();
            if (cbStatus.Text == "All")
                _dtAllReservations.DefaultView.RowFilter = "";
            else
                _dtAllReservations.DefaultView.RowFilter = string.Format("[{0}]='{1}'", FilterIColumn, FilterValue);
            lblRecordsCount.Text = dgvListReservations.Rows.Count.ToString();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddReservation frmAddReservation = new frmAddReservation();
            frmAddReservation.ShowDialog();
            frmListReservations_Load(null,null);
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ReservationID = (int)dgvListReservations.CurrentRow.Cells[0].Value;
            frmShowReservationInfo frm = new frmShowReservationInfo(ReservationID);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ReservationID = (int)dgvListReservations.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure do you want to delete Reservation [" + ReservationID + "]", "Confirm Delete", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (clsReservation.DeleteReservation(ReservationID))
            {
                MessageBox.Show("Reservation Deleted Successfully", "Successful", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                frmListReservations_Load(null, null);
            }
            else
                MessageBox.Show("Reservation Was not deleted because it has data linked to it", "Error Delete", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void _UpdateReservationStatus(clsReservation.enReservationStatus ReservationStatus)
        {
            int ReservationID = (int)dgvListReservations.CurrentRow.Cells[0].Value;
            if (MessageBox.Show($"Are you sure do you want to {ReservationStatus.ToString()} Reservation [" + ReservationID + "]", "Confirm Delete", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

           
            clsReservation Reservation = clsReservation.Find(ReservationID);
            if (Reservation == null)
                return;

            Reservation.ReservationStatus = ReservationStatus;
            if(Reservation.Save())
            {
                MessageBox.Show($"Reservation {ReservationStatus.ToString()} Successfully", "Successful", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                frmListReservations_Load(null, null);   
            }
                
            else
                MessageBox.Show($"Error to {ReservationStatus.ToString()} Reservation", "Error", MessageBoxButtons.OK,
               MessageBoxIcon.Error);

        }
        private void setCompletedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _UpdateReservationStatus(clsReservation.enReservationStatus.Completed);
        }

        private void cancToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _UpdateReservationStatus(clsReservation.enReservationStatus.Cancelled);
        }

        private void cmsListReservations_Opening(object sender, CancelEventArgs e)
        {
            string Status = (string)dgvListReservations.CurrentRow.Cells[9].Value;

            deleteToolStripMenuItem.Enabled = (Status == "Cancelled");
            cancToolStripMenuItem.Enabled = (Status == "Active");
            setCompletedToolStripMenuItem.Enabled= (Status == "Active");
        }
    }
}
