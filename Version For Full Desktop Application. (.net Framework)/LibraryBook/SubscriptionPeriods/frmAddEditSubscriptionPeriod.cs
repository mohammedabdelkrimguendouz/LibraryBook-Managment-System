using DVLD.Global_Classes;
using DVLD_Buisness;
using DVLD_Buisness.Global_Classes;
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
using TheArtOfDevHtmlRenderer.Adapters;
using static LibraryBook.People.frmAddEditPerson;

namespace LibraryBook.SubscriptionPeriods
{
    public partial class frmAddEditSubscriptionPeriod : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        private int _SubscriptionPeriodID = -1;
        private clsSubscriptionPeriod _SubscriptionPeriod;

        private int _PaymentID = -1;
        private clsPayment _Payment;
        public frmAddEditSubscriptionPeriod(int SubscriptionPeriodID)
        {
            InitializeComponent();
            _SubscriptionPeriodID = SubscriptionPeriodID;
            _Mode = enMode.Update;
        }
        public frmAddEditSubscriptionPeriod()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

       
        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = lblTitle.Text = "Add New Subscription Period";
                _SubscriptionPeriod = new clsSubscriptionPeriod();
                _Payment = new clsPayment();
                btnSave.Enabled = pSubscriptionPeriodInfo.Enabled = false;
            }
            else
            {
                this.Text = lblTitle.Text = "Edit Subscription Period";
                ctrlPersonCardInfoWithFilter1.EnableFilter = false;
            }

           
            lblPaymentID.Text = "[????]";
            lblSubscriptionPeriodID.Text = "[????]";
            rbMonthlySubscription.Checked = true;
            nudNumberOfMonth.Value = 1;
            lblStartDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblEndDate.Text = clsFormat.DateToShort(DateTime.Now.AddMonths((int)nudNumberOfMonth.Value));
            lblPaymentAmount.Text = clsSetting.DefaultMonthlySubscriptionAmount.ToString();
            txtNotes.Text = "";
            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;
        }

        private void _LoadData()
        {
            _SubscriptionPeriod = clsSubscriptionPeriod.Find(_SubscriptionPeriodID);
            if (_SubscriptionPeriod == null)
            {
                MessageBox.Show("this form well be closed because No SubscriptionPeriod With ID : " + _SubscriptionPeriodID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _Payment = clsPayment.Find(_SubscriptionPeriod.PaymentID);
            if(_Payment==null)
            {
                MessageBox.Show("this form well be closed because No Payment With ID : " + _SubscriptionPeriod.PaymentID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


            ctrlPersonCardInfoWithFilter1.LoadPersonInfo(_SubscriptionPeriod.PersonID);
            lblSubscriptionPeriodID.Text = _SubscriptionPeriod.SubscriptionPeriodID.ToString();
            lblPaymentID.Text = _Payment.PaymentID.ToString();
            int MonthsDifference =clsUtil.GetMonthsDifference(_SubscriptionPeriod.StartDate,
                _SubscriptionPeriod.EndDate);
            if (MonthsDifference <= 11)
            {
                rbMonthlySubscription.Checked = true;
                nudNumberOfMonth.Value = MonthsDifference;
            }
            else
            {
                rbAnnualSubscription.Checked = true;
                nudNumberOfMonth.Enabled = false;
            }

          
            lblStartDate.Text = clsFormat.DateToShort(_SubscriptionPeriod.StartDate);
            lblEndDate.Text = clsFormat.DateToShort(_SubscriptionPeriod.EndDate);
            lblPaymentAmount.Text = _Payment.PaymentAmount.ToString();
            txtNotes.Text = _Payment.Notes ;
            lblCreatedByUser.Text = _Payment.CreatedByUserInfo.UserName;
        }

        private void frmAddEditSubscriptionPeriod_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcSubscriptionPeriod.SelectedTab = tcSubscriptionPeriod.TabPages["tpPersonInfo"];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                tcSubscriptionPeriod.SelectedTab = tcSubscriptionPeriod.TabPages["tpSubscriptionPeriodInfo"];
                return;
            }
            

            if (ctrlPersonCardInfoWithFilter1.PersonID == -1)
            {
                MessageBox.Show("Please Select a Person  ", "Select a person",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardInfoWithFilter1.FilterFocus();
                return;

            }

            if (clsSubscriptionPeriod.IsPersonHaveActiveSubscriptionPeriod(ctrlPersonCardInfoWithFilter1.PersonID))
            {
                MessageBox.Show("Selected Person already has a Subscription Period Active ", "Not Access",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardInfoWithFilter1.FilterFocus();
                return;
            }

            pSubscriptionPeriodInfo.Enabled = true;
            btnSave.Enabled = true;
            tcSubscriptionPeriod.SelectedTab = tcSubscriptionPeriod.TabPages["tpSubscriptionPeriodInfo"];

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _Payment.PaymentDate=DateTime.Now;
            _Payment.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _Payment.PaymentAmount = Convert.ToSingle(lblPaymentAmount.Text);
            _Payment.PaymentReason = clsPayment.enPaymentReason.SubscriptionPeriod;
            _Payment.Notes = txtNotes.Text.Trim();

            if (!_Payment.Save())
                return;

            _SubscriptionPeriod.PersonID = ctrlPersonCardInfoWithFilter1.PersonID;
            _SubscriptionPeriod.PaymentID = _Payment.PaymentID;
            _SubscriptionPeriod.StartDate = Convert.ToDateTime(lblStartDate.Text);
            _SubscriptionPeriod.EndDate = Convert.ToDateTime(lblEndDate.Text);
            _SubscriptionPeriod.Status = clsSubscriptionPeriod.enSubscriptionPeriodStatus.Active;
            _SubscriptionPeriod.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_SubscriptionPeriod.Save())
            {

                this.Text = lblTitle.Text = "Edit Subscription Period";
                _Mode = enMode.Update;
                lblSubscriptionPeriodID.Text = _SubscriptionPeriod.SubscriptionPeriodID.ToString();
                lblPaymentID.Text = _Payment.PaymentID.ToString(); ;
                MessageBox.Show("Data Saved Successfully ", "Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

               
            }
            else
                MessageBox.Show("Data is not Saved Successfully ", "Error ",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rbAnnualSubscription_CheckedChanged(object sender, EventArgs e)
        {

            nudNumberOfMonth.Enabled = !(rbAnnualSubscription.Checked);
            lblEndDate.Text= (rbAnnualSubscription.Checked)? clsFormat.DateToShort(DateTime.Now.AddYears(1)):
                clsFormat.DateToShort(DateTime.Now.AddMonths((int)nudNumberOfMonth.Value));

            lblPaymentAmount.Text = (rbAnnualSubscription.Checked) ? clsSetting.DefaultAnnualSubscriptionAmount.ToString() :
                (Convert.ToSingle(nudNumberOfMonth.Value) * clsSetting.DefaultMonthlySubscriptionAmount).ToString();

        }

        private void nudNumberOfMonth_ValueChanged(object sender, EventArgs e)
        {
            lblEndDate.Text = clsFormat.DateToShort(DateTime.Now.AddMonths((int)nudNumberOfMonth.Value));
            lblPaymentAmount.Text = (Convert.ToSingle(nudNumberOfMonth.Value) * clsSetting.DefaultMonthlySubscriptionAmount).ToString();
        }
    }
}
