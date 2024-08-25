using DVLD.Global.Classes;
using DVLD.Global_Classes;
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

namespace LibraryBook.LogIn
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";
            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
                chkRememberMe.Checked = true;
            else
                chkRememberMe.Checked = false;
            txtUserName.Text = UserName;
            txtPassword.Text = Password;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string PasswordHashed = clsCryptography.ComputeHash(txtPassword.Text.Trim());
            clsUser User = clsUser.Find(txtUserName.Text.Trim(), PasswordHashed);
            if (User != null)
            {
                if (chkRememberMe.Checked)
                    clsGlobal.RememberUserNameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                else
                    clsGlobal.RememberUserNameAndPassword("", "");
                if (!User.PersonInfo.LibraryCardInfo.IsActive)
                {
                    MessageBox.Show("Your account is not active , please contact your admin !", "In Active Account",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsGlobal.CurrentUser = User;


                this.Hide();
                frmMain frm = new frmMain(this);
                frm.ShowDialog();

            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalide UserName Or Password !", "Wrong Credintials",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
