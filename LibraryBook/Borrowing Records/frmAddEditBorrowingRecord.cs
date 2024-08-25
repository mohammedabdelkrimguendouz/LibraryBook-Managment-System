using DVLD.Global.Classes;
using DVLD.Global_Classes;
using DVLD_Buisness;
using DVLD_Buisness.Global_Classes;
using LibraryBook.Books.controls;
using LibraryBook_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryBook.People.frmAddEditPerson;

namespace LibraryBook
{
    public partial class frmAddEditBorrowingRecord : Form
    {
        
        public enum enMode { AddNew=0,Update=1};
        private enMode _Mode=enMode.AddNew;


        private clsFine _Fine;
        private clsPayment _Payment;
        private int _BookCopyID = -1;
        private int _BorrowingRecordID = -1;
        private clsBorrowingRecord _BorrowingRecord;
        public frmAddEditBorrowingRecord()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditBorrowingRecord(int BorrowingRecordID)
        {
            InitializeComponent();
            _BorrowingRecordID=BorrowingRecordID;
            _Mode = enMode.Update;
        }

        private void _FillLaguagesInComboBox()
        {
            DataTable dt = clsLanguage.GetAllLanguagesForAllBookCopiesForBook(ctrlBookCardInfoWithFilter1.BookID);
            foreach (DataRow dataRow in dt.Rows)
            {
                cbLanguages.Items.Add(dataRow["LanguageName"]);
            }
            if(cbLanguages.Items.Count > 0)
                cbLanguages.SelectedIndex = 0;

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
            if(_Mode==enMode.Update)
            {
                pPersonInfo.Enabled = true;
                tcBorrowingRecord.SelectedTab = tcBorrowingRecord.TabPages["tpPersonInfo"];
                return;
            }

            if (ctrlBookCardInfoWithFilter1.BookID == -1)
            {
                MessageBox.Show("Please Select Book !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if(!(cbLanguages.Items.Count>0))
            {
                MessageBox.Show("this Book not contain any copy !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int LanguageID = clsLanguage.Find(cbLanguages.Text).ID;

            _BookCopyID = clsBookCopy.GetIDForBookCopyAvailableByBookAndLanguage(ctrlBookCardInfoWithFilter1.BookID,
                LanguageID);

            if (_BookCopyID == -1)
            {
                MessageBox.Show("No Copy Available Now !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            pPersonInfo.Enabled = true;
            tcBorrowingRecord.SelectedTab = tcBorrowingRecord.TabPages["tpPersonInfo"];

        }

        private void btnBackToBookInfo_Click(object sender, EventArgs e)
        {
            tcBorrowingRecord.SelectedTab = tcBorrowingRecord.TabPages["tpBookInfo"];
        }

        private void btnNextToBorrowingInfo_Click(object sender, EventArgs e)
        {
            if(_Mode==enMode.Update)
            {
                pBorrowingInfo.Enabled = true;
               
                tcBorrowingRecord.SelectedTab = tcBorrowingRecord.TabPages["tpBorrowingInfo"];
                return;
            }

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

            if ( !clsSubscriptionPeriod.IsPersonHaveActiveSubscriptionPeriod(
                ctrlPersonCardInfoWithFilter1.PersonID))
            {
                MessageBox.Show("this Person Don't have Active Subscription Period !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte DefaultNumberOfBorrowedBooks = clsSetting.DefaultNumberOfBorrowedBooks;

            if (clsBorrowingRecord.GetNumberOfBorrowingBooksAndNotReturnForPerson(
                ctrlPersonCardInfoWithFilter1.PersonID) > DefaultNumberOfBorrowedBooks)
            {
                MessageBox.Show(" You have reached the maximum number of borrowing . \r\n" +
                    $"Default Number Of Borrowed Books = {DefaultNumberOfBorrowedBooks} !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            pBorrowingInfo.Enabled=true;
            btnSave.Enabled=true;
            tcBorrowingRecord.SelectedTab = tcBorrowingRecord.TabPages["tpBorrowingInfo"];



        }

        private void btnBackToPersonInfo_Click(object sender, EventArgs e)
        {
            tcBorrowingRecord.SelectedTab = tcBorrowingRecord.TabPages["tpPersonInfo"];
        }

       

        private void _ResetDefaultValues()
        {
            
            if (_Mode == enMode.AddNew)
            {
                this.Text = lblTitle.Text = "Add New Borrowing Record";
                _BorrowingRecord = new clsBorrowingRecord();
                btnSave.Enabled=false;
                if (ctrlBookCardInfoWithFilter1.BookID != -1)
                    _FillLaguagesInComboBox();

            }
            else
            {
                this.Text = lblTitle.Text = "Edit Borrowing Record";
            }
            lblBorrowingRecordID.Text = "[????]";
            lblBorrowingDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedByUser.Text =  clsGlobal.CurrentUser.UserName;
            
            byte DefualtBorrrowDays = clsSetting.DefualtBorrrowDays;
            lblDueDate.Text=clsFormat.DateToShort(DateTime.Now.AddDays(DefualtBorrrowDays));
            lblActualReturnDate.Text=clsFormat.DateToShort(DateTime.Now);
           

            chkIsReturnBook.Checked = false;
            lblFineAmount.Text = "[????]";
            lblFineID.Text = "[????]";
            lblNumberOfLateDays.Text = "[????]";
            txtNotes.Text = "";
        }

        private void _LoadData()
        {
           
            _BorrowingRecord = clsBorrowingRecord.Find(_BorrowingRecordID);
            if (_BorrowingRecord == null)
            {
                MessageBox.Show("this form well be closed because No Borrowing With ID : " + _BorrowingRecordID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlBookCardInfoWithFilter1.EnableFilter = false;
            ctrlBookCardInfoWithFilter1.LoadBookInfo(_BorrowingRecord.BookCopyInfo.BookID);


            cbLanguages.Items.Add(_BorrowingRecord.BookCopyInfo.LanguageInfo.LanguageName);
            cbLanguages.SelectedIndex = 0;
            cbLanguages.Enabled = false;

            ctrlPersonCardInfoWithFilter1.EnableFilter=false;
            ctrlPersonCardInfoWithFilter1.LoadPersonInfo(_BorrowingRecord.PersonID);

            lblBorrowingRecordID.Text = _BorrowingRecord.BorrowingRecordID.ToString();
            lblBorrowingDate.Text=clsFormat.DateToShort(_BorrowingRecord.BorrowingDate);
            lblDueDate.Text= clsFormat.DateToShort(_BorrowingRecord.DueDate);
            if(_BorrowingRecord.ActualReturnDate != null)
            {
                lblActualReturnDate.Text =clsFormat.DateToShort(_BorrowingRecord.ActualReturnDate.Value);
                chkIsReturnBook.Checked = true;
                chkIsReturnBook.Enabled=false;
                btnSave.Enabled=false;
            }
            
            
            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;
            _BookCopyID=_BorrowingRecord.BookCopyID;


            _Fine= clsFine.FindByBorrowingRecord(_BorrowingRecordID);
            if(_Fine==null)
            {
                int NumberOfLateDays = clsUtil.GetDaysDifference(_BorrowingRecord.DueDate, DateTime.Now);
                if (NumberOfLateDays > 0)
                {
                    _Fine=new clsFine();
                    gbFineInfo.Enabled = true;
                    lblMessage.Visible=true;
                    lblNumberOfLateDays.Text=NumberOfLateDays.ToString();
                    lblFineAmount.Text=((float)(NumberOfLateDays)*clsSetting.DefaultFinePerDay).ToString();
                }
                return;
            }
                

            lblFineID.Text=_Fine.FineID.ToString();
            lblMessage.Visible = true;
            lblNumberOfLateDays.Text=_Fine.NumberOfLateDays.ToString();
            lblFineAmount.Text=_Fine.FineAmount.ToString();
            chkPaid.Checked= _Fine.Paid;
            gbFineInfo.Enabled = ! _Fine.Paid;
            
        }
        private void frmAddEditBorrowingRecord_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        
        private void _CheckIsBookCopyReserved()
        {
            int ReservationID=clsReservation.GetReservationIDIfBookCopyReserved(_BookCopyID);
            if (ReservationID == -1)
                return;

            clsReservation Reservation = clsReservation.Find(ReservationID);
            if(Reservation == null) 
                return;

            // Prepare Email 
            string Email=Reservation.PersonInfo.Email;
            string Subject = $"Hello [{Reservation.PersonInfo.FullName}],\r\n\r\nWe hope this message finds you well.";
            string Body = $"We are pleased to inform you that the book you reserved," +
                $" titled \"[{Reservation.BookCopyInfo.BookInfo.Title}],\" is now available at our library." +
                $" You can visit us anytime to collect it" +
                $".\r\n\r\nPlease note that the book will be reserved for you for [{clsSetting.DefaultNumberOfDaysWaitingForABookReserved}] days from the date of this email." +
                $" If you are unable to collect it within this period, your reservation will be canceled, and the book will be made available to others." +
                $"\r\n\r\nIf you have any questions or concerns, please feel free to reach out to us.\r\n";

           //Send Email
            clsContact.SendEmail(Email, Subject, Body);


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _BorrowingRecord.PersonID = ctrlPersonCardInfoWithFilter1.PersonID;
            _BorrowingRecord.BookCopyID = _BookCopyID;
            _BorrowingRecord.BorrowingDate=Convert.ToDateTime(lblBorrowingDate.Text);
            _BorrowingRecord.DueDate= Convert.ToDateTime(lblDueDate.Text);
           
            _BorrowingRecord.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (chkIsReturnBook.Checked)
                _BorrowingRecord.ActualReturnDate = Convert.ToDateTime(lblActualReturnDate.Text);
            else
                _BorrowingRecord.ActualReturnDate = null;

            if(_BorrowingRecord.Save())
            {
                this.Text = lblTitle.Text = "Edit Borrwing Record ";
                _Mode = enMode.Update;
                lblBorrowingRecordID.Text = _BorrowingRecord.BorrowingRecordID.ToString();
                _BorrowingRecordID=_BorrowingRecord.BorrowingRecordID;

                

                MessageBox.Show("Data Saved Successfully ", "Saved",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (_BorrowingRecord.ActualReturnDate != null)
                    Parallel.Invoke(_CheckIsBookCopyReserved);
            }
            else
                MessageBox.Show("Data is not Saved Successfully ", "Error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);




                

        }

        private void btnPayFine_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
                return;



            if(chkPaid.Checked)
            {
                _Payment = new clsPayment();
                _Payment.Notes =txtNotes.Text.Trim();
                _Payment.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                _Payment.PaymentDate = DateTime.Now;
                _Payment.PaymentAmount =Convert.ToSingle(lblFineAmount.Text);
                _Payment.PaymentReason = clsPayment.enPaymentReason.Fine;
                _Payment.Save();
            }
            if (_Payment!=null && _Payment.PaymentID == -1)
                return;
               
            _Fine.BorrowingRecordID = _BorrowingRecordID;
            _Fine.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _Fine.FineAmount = Convert.ToSingle(lblFineAmount.Text);
            _Fine.NumberOfLateDays=int.Parse(lblNumberOfLateDays.Text);
            _Fine.PersonID = ctrlPersonCardInfoWithFilter1.PersonID;
            _Fine.Paid = (_Payment != null);
            if (_Payment == null)
                _Fine.PaymentID = null;
            else
                _Fine.PaymentID= _Payment.PaymentID;

            if(_Fine.Save())
            {
                MessageBox.Show("Fine Saved Successfully ", "Info ",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbFineInfo.Enabled = _Fine.PaymentID == -1;
                lblFineID.Text = _Fine.FineID.ToString();
            }
              
            else
                MessageBox.Show("Fine is not Saved Successfully ", "Error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
