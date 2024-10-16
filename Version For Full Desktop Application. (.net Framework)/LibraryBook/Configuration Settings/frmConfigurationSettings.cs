using DVLD_Buisness.Global_Classes;
using Guna.UI2.WinForms;
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

namespace LibraryBook.ConfigurationSettings
{
    public partial class frmConfigurationSettings : Form
    {
        public frmConfigurationSettings()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidateEmptyTextBoxAndIsNumber(object sender, CancelEventArgs e)
        {
            Guna2TextBox Temp=(Guna2TextBox)sender;
            if(string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This Faild cannot be empty !");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
            if (!clsValidation.IsNumber(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "Invalide Number !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            clsSetting.DefualtBorrrowDays =(byte) nudDefualtBorrrowDays.Value;
            clsSetting.DefaultNumberOfBorrowedBooks = (byte)nudDefaultNumberOfBorrowedBooks.Value;
            clsSetting.DefaultNumberOfDaysWaitingForABookReserved = (byte)nudDefaultNumberOfDaysWaitingForABookReserved.Value;
            clsSetting.DefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod =
                (byte)nudDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod.Value;


            clsSetting.DefaultFinePerDay = Convert.ToSingle(txtDefaultFinePerDay.Text.Trim());
            clsSetting.DefaultMonthlySubscriptionAmount = Convert.ToSingle(txtDefaultMonthlySubscriptionAmount.Text.Trim());
            clsSetting.DefaultAnnualSubscriptionAmount = Convert.ToSingle(txtDefaultAnnualSubscriptionAmount.Text.Trim());

            MessageBox.Show("Data Saved Successfully ", "Saved",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmConfigurationSettings_Load(object sender, EventArgs e)
        {
            nudDefualtBorrrowDays.Value = clsSetting.DefualtBorrrowDays;
            nudDefaultNumberOfBorrowedBooks.Value = clsSetting.DefaultNumberOfBorrowedBooks;
            nudDefaultNumberOfDaysWaitingForABookReserved.Value = clsSetting.DefaultNumberOfDaysWaitingForABookReserved;
            nudDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod.Value =
                clsSetting.DefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod;

            txtDefaultFinePerDay.Text = clsSetting.DefaultFinePerDay.ToString();
            txtDefaultMonthlySubscriptionAmount.Text = clsSetting.DefaultMonthlySubscriptionAmount.ToString();
            txtDefaultAnnualSubscriptionAmount.Text = clsSetting.DefaultAnnualSubscriptionAmount.ToString();

        }
    }
}
