using DVLD.Global_Classes;
using DVLD_Buisness.Global_Classes;
using LibraryBook_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBook.Reservations
{
    public partial class frmAddReservation : Form
    {
       
        private int _BookCopyID = -1;
        private int _BookID = -1;
        private int _ReservationID = -1;
        private clsReservation _Reservation;
      
        public frmAddReservation()
        {
            InitializeComponent();
           
        }

        public frmAddReservation(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
        }


        private void _FillLaguagesInComboBox()
        {
            DataTable dt = clsLanguage.GetAllLanguagesForAllBookCopiesForBook(ctrlBookCardInfoWithFilter1.BookID);
            foreach (DataRow dataRow in dt.Rows)
            {
                cbLanguages.Items.Add(dataRow["LanguageName"]);
            }
            if (cbLanguages.Items.Count > 0)
                cbLanguages.SelectedIndex = 0;

        }
        private void _ResetDefaultValues()
        {
            
            
            this.Text = lblTitle.Text = "Add New Reservation";
            _Reservation = new clsReservation();
            btnReserve.Enabled = false;




            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;
            lblReservationID.Text = "[????]";
            lblReservationStatus.Text = clsReservation.enReservationStatus.Active.ToString();

            lblReservationDate.Text = DateTime.Now.ToString();
        }

       
        private void frmAddEditReservation_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if(_BookID != -1 && clsBook.IsBookExist(_BookID))
            {
                ctrlBookCardInfoWithFilter1.EnableFilter = false;
                ctrlBookCardInfoWithFilter1.LoadBookInfo(_BookID);
                _FillLaguagesInComboBox();
            }
               

        }

        private void ctrlBookCardInfoWithFilter1_OnBookSelected(object sender, Books.controls.ctrlBookCardInfoWithFilter.BookSelectedEventArgs e)
        {
            cbLanguages.Items.Clear();

            cbLanguages.Enabled = (e.BookID != -1);
            if (cbLanguages.Enabled)
                _FillLaguagesInComboBox();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNextToPersonInfo_Click(object sender, EventArgs e)
        {
           

            if (ctrlBookCardInfoWithFilter1.BookID == -1)
            {
                MessageBox.Show("Please Select Book !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!(cbLanguages.Items.Count > 0))
            {
                MessageBox.Show("this Book not contain any copy !", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            int LanguageID = clsLanguage.Find(cbLanguages.Text).ID;

            _BookCopyID = clsBookCopy.GetIDForBookCopyAvailableByBookAndLanguage(ctrlBookCardInfoWithFilter1.BookID,
                LanguageID);

            if (_BookCopyID != -1)
            {
                MessageBox.Show("is exist copy not Reservation can you Borrowing !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _BookCopyID = clsBookCopy.GetIDForBookCopyNotAvailableByBookAndLanguage(ctrlBookCardInfoWithFilter1.BookID,
               LanguageID);

            if(_BookCopyID == -1)
            {
                MessageBox.Show("All Book Copies Reserved !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            pPersonInfo.Enabled = true;
            tcReservation.SelectedTab = tcReservation.TabPages["tpPersonInfo"];
        }

        private void btnBackToBookInfo_Click(object sender, EventArgs e)
        {
            tcReservation.SelectedTab = tcReservation.TabPages["tpBookInfo"];
        }

        private void btnNextToReservationInfo_Click(object sender, EventArgs e)
        {
            

            if (ctrlPersonCardInfoWithFilter1.PersonID == -1)
            {
                MessageBox.Show("Please Select Person !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsFine.IsPersonHaveFineNotPaid(
                ctrlPersonCardInfoWithFilter1.PersonID))
            {
                MessageBox.Show("this Person Have Fine Not Paid !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!clsSubscriptionPeriod.IsPersonHaveActiveSubscriptionPeriod(
                ctrlPersonCardInfoWithFilter1.PersonID))
            {
                MessageBox.Show("this Person Don't have Active Subscription Period !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            
            btnReserve.Enabled = true;
            pReservationInfo.Enabled = true;

            tcReservation.SelectedTab = tcReservation.TabPages["tpReservationInfo"];
            
        }

        private void btnBackToPersonInfo_Click(object sender, EventArgs e)
        {
            tcReservation.SelectedTab = tcReservation.TabPages["tpPersonInfo"];
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            _Reservation.ReservationStatus = clsReservation.enReservationStatus.Active;
            _Reservation.ReservationDate = Convert.ToDateTime(lblReservationDate.Text);
            _Reservation.BookCopyID = _BookCopyID;
            _Reservation.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _Reservation.PersonID = ctrlPersonCardInfoWithFilter1.PersonID;


            if (_Reservation.Save())
            {

                lblReservationID.Text = _Reservation.ReservationID.ToString();
                _ReservationID = _Reservation.ReservationID;
                btnReserve.Enabled = false;
                MessageBox.Show("Book Reserved Successfully ", "Saved",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Book is not Reserved Successfully ", "Error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
