using DVLD.Global_Classes;
using DVLD_Buisness;
using DVLD_Buisness.Global_Classes;
using Guna.UI2.WinForms;
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
using System.IO;
using LibraryBook.Authors.Controls;

namespace LibraryBook.People
{
    public partial class frmAddEditPerson : Form
    {
        public class PersonEventArgs : EventArgs
        {
            public int PersonID { get; }
            public PersonEventArgs(int PersonID)
            {
                this.PersonID = PersonID;
            }
        }

        public delegate void DataBackEventHandler(object sender, PersonEventArgs e);

        public event DataBackEventHandler DataBack;
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        

        private int _PersonID = -1;
        private clsPerson _Person;
        private int _LibraryCardID=-1;
        public frmAddEditPerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonID = PersonID;
            
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = lblTitle.Text = "Add New Person";
                _Person = new clsPerson();
               
            }
            else
            {
                this.Text = lblTitle.Text = "Edit Person";
            }


            lblPersonID.Text = "[????]";
            lblCardNumber.Text= "[????]";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMidlleName.Text = "";
            txtNationalNo.Text = "";
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-9);
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
            pbPersonImage.ImageLocation = null;
            rbMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
      
            txtAddress.Text = "";
            
               
        }

        private void _LoadData()
        {
            _Person = clsPerson.Find(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("this form well be closed because No Person With ID : " + _PersonID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            _LibraryCardID = _Person.LibraryCardID;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblCardNumber.Text = _Person.LibraryCardInfo.LibraryCardNumber;
            txtAddress.Text = _Person.Address;
            txtFirstName.Text = _Person.FirstName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            txtMidlleName.Text = _Person.MidlleName;
        
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            
            rbMale.Checked = (clsPerson.enGender.Male == _Person.Gender) ? true : rbFemale.Checked = false;
            pbPersonImage.ImageLocation = _Person.ImagePath;
            llRemoveImage.Visible = (pbPersonImage.ImageLocation != "");
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "Choose Image ";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbPersonImage.ImageLocation = openFileDialog1.FileName;
                llRemoveImage.Visible = true;
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;
            llRemoveImage.Visible = false;
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender;
            if (string.IsNullOrEmpty(Temp.Text))
            {
                e.Cancel = true;
                Temp.Focus();
                errorProvider1.SetError(Temp, "This field is required !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
                return;

            if (!clsValidation.ValidateEmail(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Invalide Formate Email (yourmail'[6-30 Letter]'.gmail.com)");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void pbPersonImage_Validating(object sender, CancelEventArgs e)
        {
            if (pbPersonImage.ImageLocation==null)
            {
                e.Cancel = true;
                
                errorProvider1.SetError(pbPersonImage, "This field is required !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(pbPersonImage, null);
            }
        }

        private bool _HabdelPersonImage()
        {
            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (Exception Ex)
                    {
                        return false;
                    }
                }
                if (pbPersonImage.ImageLocation != null)
                {
                    string SourceImageFile = pbPersonImage.ImageLocation;
                    if (clsUtil.CopyImageToImagesPeopleFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;

                    }
                }
                else
                {
                    MessageBox.Show("Please Select Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private bool _HandelLibraryCard()
        {
            if (_Mode == enMode.AddNew)
            {
                clsLibraryCard  LibraryCard = new clsLibraryCard();
                LibraryCard.IsActive = true;
                LibraryCard.LibraryCardNumber ="LIB-"+ clsUtil.GenerateGuid().ToUpper();
                LibraryCard.IssueDate = DateTime.Now;
                if (!LibraryCard.Save())
                    return false;
                else
                {
                    lblCardNumber.Text = LibraryCard.LibraryCardNumber;
                    _LibraryCardID = LibraryCard.LibraryCardID;
                }
                    
            }
            
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_HabdelPersonImage())
                return;
            if (!_HandelLibraryCard())
                return;

            _Person.LibraryCardID = _LibraryCardID;
            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.MidlleName = txtMidlleName.Text.Trim();
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Gender = (rbMale.Checked) ? clsPerson.enGender.Male : clsPerson.enGender.Female;
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.ImagePath = pbPersonImage.ImageLocation;
            if (_Person.Save())
            {

                this.Text = lblTitle.Text = "Edit Person ";
                _Mode = enMode.Update;
                lblPersonID.Text = _Person.PersonID.ToString();
                _PersonID = _Person.PersonID;
                MessageBox.Show("Data Saved Successfully ", "Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataBack?.Invoke(this,new PersonEventArgs(_Person.PersonID));
            }
            else
                MessageBox.Show("Data is not Saved Successfully ", "Error ",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
