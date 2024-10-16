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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace LibraryBook.Users
{
    public partial class frmChangePassword : Form
    {
        private int _UserID = -1;
        private clsUser _User;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            txtConfirmPassword.Focus();
            _User = clsUser.Find(_UserID);
            if (_User == null)
            {
                MessageBox.Show("No User With ID = " + _UserID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                gbChangePassword.Enabled = false;
                return;
            }
            ctrlUserCardInfo1.LoadUserInfo(_UserID);
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match password !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {

            if (txtNewPassword.Text.Trim() == "")
            {
                e.Cancel = true;
                txtNewPassword.Focus();
                errorProvider1.SetError(txtNewPassword, "This field cannot be empty !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNewPassword, null);
            }
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtCurrentPassword, "Current Password cannot be empty !");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }

            string PasswordHashed = clsCryptography.ComputeHash(txtCurrentPassword.Text.Trim());
            if (PasswordHashed != _User.Password)
            {
                e.Cancel = true;
                txtCurrentPassword.Focus();
                errorProvider1.SetError(txtCurrentPassword, "Current password is wrong !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCurrentPassword, null);
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

            string NewPasswordHashed = clsCryptography.ComputeHash(txtNewPassword.Text.Trim());

            _User.Password = NewPasswordHashed;
            if (_User.Save())
            {
                MessageBox.Show("Password Changed successfully", "Saved",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show(" Password was not Changed successfully", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
