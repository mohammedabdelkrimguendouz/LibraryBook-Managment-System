using DVLD_Buisness;
using DVLD_Buisness.Global_Classes;
using LibraryBook.Payments;
using LibraryBook.People;
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

namespace LibraryBook.SubscriptionPeriods
{
    public partial class ctrlSubscriptionPeriodCardInfo : UserControl
    {
        private int _SubscriptionPeriodID = -1;
        public int SubscriptionPeriodID { get { return _SubscriptionPeriodID; } }

        private clsSubscriptionPeriod _SubscriptionPeriod;
        public clsSubscriptionPeriod SelectedSubscriptionPeriodInfo { get { return _SubscriptionPeriod; } }
        public ctrlSubscriptionPeriodCardInfo()
        {
            InitializeComponent();
        }
        public void LoadSubscriptionPeriodInfo(int SubscriptionPeriodID)
        {
            _SubscriptionPeriod = clsSubscriptionPeriod.Find(SubscriptionPeriodID);
            if (_SubscriptionPeriod == null)
            {
                ResetSubscriptionPeriodInfo();
                MessageBox.Show("No SubscriptionPeriod With ID = " + SubscriptionPeriodID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillSubscriptionPeriodInfo();

        }
        private void _FillSubscriptionPeriodInfo()
        {
            _SubscriptionPeriodID = _SubscriptionPeriod.SubscriptionPeriodID;
            lblSubscriptionPeriodID.Text = _SubscriptionPeriod.SubscriptionPeriodID.ToString();
            lblStatus.Text = _SubscriptionPeriod.Status.ToString();
            lblEndDate.Text = clsFormat.DateToShort(_SubscriptionPeriod.EndDate);
            lblStartDate.Text = clsFormat.DateToShort(_SubscriptionPeriod.StartDate);
            lblCreatedByUser.Text = _SubscriptionPeriod.CreatedByUserInfo.UserName;
            llShowPaymentInfo.Enabled = true;
            llShowPersonInfo.Enabled = true;
        }

      
        public void ResetSubscriptionPeriodInfo()
        {
            _SubscriptionPeriodID = -1;
            lblSubscriptionPeriodID.Text = "[????]";
            lblStatus.Text = "[????]";
            lblEndDate.Text = "[????]";
            lblStartDate.Text = "[????]";
            lblCreatedByUser.Text = "[????]";
            llShowPaymentInfo.Enabled = false;
            llShowPersonInfo.Enabled = false;
        }

      

        private void llShowPaymentInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPaymentInfo frm = new frmShowPaymentInfo(_SubscriptionPeriod.PaymentID);
            frm.ShowDialog();
        }

        private void llShowPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo(_SubscriptionPeriod.PersonID);
            frm.ShowDialog();
        }
    }
}
