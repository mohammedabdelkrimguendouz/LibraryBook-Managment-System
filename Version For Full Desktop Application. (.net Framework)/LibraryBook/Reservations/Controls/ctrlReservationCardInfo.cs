using LibraryBook.Books.controls;
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

namespace LibraryBook.Reservations
{
    public partial class ctrlReservationCardInfo : UserControl
    {
        private int _ReservationID = -1;
        public int ReservationID { get { return _ReservationID; } }

        private clsReservation _Reservation;
        public clsReservation SelectedReservationInfo { get { return _Reservation; } }
        public ctrlReservationCardInfo()
        {
            InitializeComponent();
        }
        public void LoadReservationInfo(int ReservationID)
        {
            _Reservation = clsReservation.Find(ReservationID);
            if (_Reservation == null)
            {
                ResetReservationInfo();
                MessageBox.Show("No Find Reservation With ID = " + ReservationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillReservationInfo();

        }
        private void _FillReservationInfo()
        {
            _ReservationID = _Reservation.ReservationID;
            lblReservationID.Text = _Reservation.ReservationID.ToString();
            lblReservationDate.Text = _Reservation.ReservationDate.ToString();
            lblReservationStatus.Text = _Reservation.ReservationStatus.ToString();
            lblCreatedByUser.Text = _Reservation.CreatedByUserInfo.UserName;
            llShowBookCopyInfo.Enabled = true;
            llShowPersonInfo.Enabled = true;
        }

        public void ResetReservationInfo()
        {
            _ReservationID = -1;
            lblReservationID.Text = "[????]";
            lblReservationDate.Text = "[????]";
            lblReservationStatus.Text = "[????]";
            lblCreatedByUser.Text = "[????]";
            llShowBookCopyInfo.Enabled = false;
            llShowPersonInfo.Enabled = false;
        }

        private void llShowPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmShowPersonInfo frm = new frmShowPersonInfo(_Reservation.PersonID);
            frm.ShowDialog();

        }

        private void llShowBookCopyInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowBookCopyInfo frm=new frmShowBookCopyInfo(_Reservation.BookCopyID);
            frm.ShowDialog();
        }
    }
}
