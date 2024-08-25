using DVLD_Buisness.Global_Classes;
using LibraryBook.Borrowing_Records;
using LibraryBook.Payments;
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

namespace LibraryBook.Fines.Controls
{
    public partial class ctrlFineInfo : UserControl
    {
        private int _FineID = -1;
        public int FineID { get { return _FineID; } }

        private clsFine _Fine;
        public clsFine SelectedFineInfo { get { return _Fine; } }
        public ctrlFineInfo()
        {
            InitializeComponent();
        }
        public void LoadFineInfo(int FineID)
        {
            _Fine = clsFine.FindByID(FineID);
            if (_Fine == null)
            {
                ResetFineInfo();
                MessageBox.Show("No Find Record With ID = " + FineID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillFineInfo();

        }
        private void _FillFineInfo()
        {
            _FineID = _Fine.FineID;
            lblFineID.Text = _Fine.FineID.ToString();
            lblNumberOfLateDays.Text= _Fine.NumberOfLateDays.ToString();
            lblFineAmount.Text = _Fine.FineAmount.ToString();
            lblPaid.Text = (_Fine.Paid) ? "yes" : "No";
            lblCreatedByUser.Text=_Fine.CreatedByUserInfo.UserName;
            llBorrowingRecordInfo.Enabled = true;
            llShowPaymentInfo.Enabled = _Fine.Paid;
            llShowPersonInfo.Enabled = true;
        }

        public void ResetFineInfo()
        {
            _FineID = -1;
            lblFineID.Text = "[????]";
            lblNumberOfLateDays.Text = "[????]";
            lblFineAmount.Text = "[????]";
            lblPaid.Text = "[????]";
            lblCreatedByUser.Text = "[????]";
            llBorrowingRecordInfo.Enabled = false;
            llShowPaymentInfo.Enabled = false;
            llShowPersonInfo.Enabled = false;
        }

        private void llBorrowingRecordInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowBorrowinRecordInfo frm = new frmShowBorrowinRecordInfo(_Fine.BorrowingRecordID);
            frm.ShowDialog();
        }

        private void llShowPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo(_Fine.PersonID);
            frm.ShowDialog();
        }

        private void llShowPaymentInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPaymentInfo frm = new frmShowPaymentInfo(_Fine.PaymentID.Value);
            frm.ShowDialog();
        }
    }
}
