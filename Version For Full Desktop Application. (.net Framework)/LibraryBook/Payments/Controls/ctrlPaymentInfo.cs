using DVLD_Buisness;
using DVLD_Buisness.Global_Classes;
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

namespace LibraryBook.Payments.Controls
{
    public partial class ctrlPaymentInfo : UserControl
    {
        private int _PaymentID = -1;
        public int PaymentID { get { return _PaymentID; } }

        private clsPayment _Payment;
        public clsPayment SelectedPaymentInfo { get { return _Payment; } }
        public ctrlPaymentInfo()
        {
            InitializeComponent();
        }
        public void LoadPaymentInfo(int PaymentID)
        {
            _Payment = clsPayment.Find(PaymentID);
            if (_Payment == null)
            {
                ResetPaymentInfo();
                MessageBox.Show("No Payment With ID = " + PaymentID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
            _FillPaymentInfo();

        }
        private void _FillPaymentInfo()
        {
            _PaymentID = _Payment.PaymentID;
            lblPaymentID.Text = _Payment.PaymentID.ToString();
            lblPaymentDate.Text = clsFormat.DateToShort(_Payment.PaymentDate);
            lblPaymentReason.Text = _Payment.PaymentReason.ToString();
            lblPaymentAmount.Text = _Payment.PaymentAmount.ToString();
            lblCreatedByUser.Text = _Payment.CreatedByUserInfo.UserName;
            lblNotes.Text = _Payment.Notes;
            
        }

        

        public void ResetPaymentInfo()
        {
            _PaymentID = -1;
            lblPaymentID.Text = "[????]";
            lblPaymentDate.Text = "[????]";
            lblPaymentReason.Text = "[????]";
            lblPaymentAmount.Text = "[????]";
            lblCreatedByUser.Text = "[????]";
            lblNotes.Text = "[????]";

        }
    }
}
