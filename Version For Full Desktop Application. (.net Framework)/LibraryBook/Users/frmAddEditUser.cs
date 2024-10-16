using DVLD.Global.Classes;
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

namespace LibraryBook.Users
{
    public partial class frmAddEditUser : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;

        private int _UserID = -1;
        private clsUser _User;
        public frmAddEditUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _UserID = UserID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);
            if (_User == null)
            {
                MessageBox.Show("this form well be closed because No User With ID : " + _UserID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ctrlPersonCardInfoWithFilter1.LoadPersonInfo(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = lblTitle.Text = "Add New User";
                _User = new clsUser();
                btnSave.Enabled = false;
                gbUserInfo.Enabled = false;
            }
            else
            {
                this.Text = lblTitle.Text = "Edit User";
                ctrlPersonCardInfoWithFilter1.EnableFilter = false;
            }
      
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (txtUserName.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "This field is required !");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, null);
            }

            if (_User.UserName != txtUserName.Text.Trim() && clsUser.IsUserExist(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "User Name is used for another User !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "This field cannot be empty !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match password !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, null);
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


            _User.UserName = txtUserName.Text.Trim();
            string PasswordHashed = clsCryptography.ComputeHash(txtPassword.Text.Trim());
            _User.Password = PasswordHashed;


            _User.PersonID = ctrlPersonCardInfoWithFilter1.PersonID;
            if (_User.Save())
            {
                this.Text = lblTitle.Text = "Update User ";
                _Mode = enMode.Update;
                lblUserID.Text = _User.UserID.ToString();

                MessageBox.Show("Data Saved Successfully ", "Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
                MessageBox.Show("Data is not Saved Successfully ", "Error ",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ctrlPersonCardInfoWithFilter1_OnPersonSelected(object sender, People.Controls.ctrlPersonCardInfoWithFilter.PersonSelectedEventArgs e)
        {
            if (e.PersonID == -1)
                return;

            if (clsUser.IsUserExistForPersonID(e.PersonID))
            {
                MessageBox.Show("Selected Person already has a User", "Not Access",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardInfoWithFilter1.FilterFocus();
                return;
            }
            gbUserInfo.Enabled =true;
            btnSave.Enabled = true;
        }

        private void ctrlPersonCardInfoWithFilter1_Load(object sender, EventArgs e)
        {

        }
    }
}
