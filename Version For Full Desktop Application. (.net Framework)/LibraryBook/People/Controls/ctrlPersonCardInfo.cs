using DVLD_Buisness;
using DVLD_Buisness.Global_Classes;
using LibraryBook.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBook.People.Controls
{
    public partial class ctrlPersonCardInfo : UserControl
    {
        private int _PersonID = -1;
        public int PersonID { get { return _PersonID; } }

        private clsPerson _Person;
        public clsPerson SelectedPersonInfo { get { return _Person; } }

        public ctrlPersonCardInfo()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person With ID = " + PersonID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();

        }
        private void _FillPersonInfo()
        {
            _PersonID = _Person.PersonID;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblCardNumber.Text = _Person.LibraryCardInfo.LibraryCardNumber;
            lblAddress.Text = _Person.Address;
            lblName.Text = _Person.FullName;
            lblNationalNo.Text = _Person.NationalNo;
            lblEmail.Text = _Person.Email;
            lblDateOfBirth.Text = clsFormat.DateToShort(_Person.DateOfBirth);
            lblPhone.Text = _Person.Phone;
            lblGender.Text = (_Person.Gender == clsPerson.enGender.Male) ? "Male" : "Female";
            pbGender.Image = (_Person.Gender == clsPerson.enGender.Male) ? Resources.male_32 : Resources.female_32;
            llEditPersonInfo.Enabled = true;
            pbPersonImage.ImageLocation = _Person.ImagePath;
            lblIsActive.Text = (_Person.LibraryCardInfo.IsActive) ? "Yes" : "No";
            lblIssueCardDate.Text = clsFormat.DateToShort(_Person.LibraryCardInfo.IssueDate);
        }

        public void LoadPersonInfo(string LibraryCardNumber)
        {
            _Person = clsPerson.Find(LibraryCardNumber);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person With Library Card Number = " + LibraryCardNumber, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }

        public void ResetPersonInfo()
        {
            lblAddress.Text = "[????]";
            lblIsActive.Text = "[????]";
            lblIssueCardDate.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblCardNumber.Text= "[????]";
            lblName.Text = "[????]";
            lblGender.Text = "[????]";
            pbGender.Image = Resources.male_32;
            lblEmail.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblPhone.Text = "[????]";
            lblPersonID.Text = "[????]";
            llEditPersonInfo.Enabled = false;
            pbPersonImage.Image =null;
            _PersonID = -1;
        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(_PersonID);
            frm.ShowDialog();
            LoadPersonInfo(_PersonID);
        }
    }
}
