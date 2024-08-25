using DVLD_Buisness.Global_Classes;
using LibraryBook_Buisness;
using LibraryBook.Properties;
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
using LibraryBook.People;
using LibraryBook.Books.controls;

namespace LibraryBook.Borrowing_Records
{
    public partial class ctrlBorrowingRecordInfo : UserControl
    {
        private int _BorrowingRecordID = -1;
        public int BorrowingRecordID { get { return _BorrowingRecordID; } }

        private clsBorrowingRecord _BorrowingRecord;
        public clsBorrowingRecord SelectedBorrowingRecordInfo { get { return _BorrowingRecord; } }
        public ctrlBorrowingRecordInfo()
        {
            InitializeComponent();
        }

        public void LoadBorrowingRecordInfo(int BorrowingRecordID)
        {
            _BorrowingRecord = clsBorrowingRecord.Find(BorrowingRecordID);
            if (_BorrowingRecord == null)
            {
                ResetBorrowingRecordInfo();
                MessageBox.Show("No Borrowing Record With ID = " + BorrowingRecordID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillBorrowingRecordInfo();

        }
        private void _FillBorrowingRecordInfo()
        {
            _BorrowingRecordID = _BorrowingRecord.BorrowingRecordID;
            lblBorrowingRecordID.Text = _BorrowingRecord.BorrowingRecordID.ToString();
            lblBorrowingDate.Text=clsFormat.DateToShort(_BorrowingRecord.BorrowingDate);
            lblDueDate.Text= clsFormat.DateToShort(_BorrowingRecord.DueDate);
            lblActualReturnDate.Text=(_BorrowingRecord.ActualReturnDate==null)?"Not Yet":
                 clsFormat.DateToShort(_BorrowingRecord.ActualReturnDate.Value);

            lblCreatedByUser.Text = _BorrowingRecord.CreatedByUserInfo.UserName;
            llShowBookCopyInfo.Enabled = true;
            llShowPersonInfo.Enabled = true;
        }

        public void ResetBorrowingRecordInfo()
        {
            _BorrowingRecordID = -1;
            lblBorrowingRecordID.Text = "[????]";
            lblBorrowingDate.Text = "[????]";
            lblDueDate.Text = "[????]";
            lblActualReturnDate.Text = "[????]";

            lblCreatedByUser.Text = "[????]";
            llShowBookCopyInfo.Enabled = false;
            llShowPersonInfo.Enabled = false;
        }

        private void llShowPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo(_BorrowingRecord.PersonID);
            frm.ShowDialog();
        }

        private void llShowBookCopyInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowBookCopyInfo frm = new frmShowBookCopyInfo(_BorrowingRecord.BookCopyID);
            frm.ShowDialog();
        }
    }
}
