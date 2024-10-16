using LibraryBook.People.Controls;
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

namespace LibraryBook.Users.Controls
{
    public partial class ctrlUserCardInfo : UserControl
    {
        private int _UserID = -1;
        public int UserID { get { return _UserID; } }

        private clsUser _User;
        public clsUser SelectedUserInfo { get { return _User; } }
        public ctrlUserCardInfo()
        {
            InitializeComponent();
        }

        public void ResetUserInfo()
        {
            ctrlPersonCardInfo1.ResetPersonInfo();
            lblUserID.Text = "[????]";
            lblUserName.Text = "[????]";
            _UserID = -1;
        }

        private void _FillUserInfo()
        {
            ctrlPersonCardInfo1.LoadPersonInfo(_User.PersonID);
            _UserID = _User.UserID;
            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName;
        }
        public void LoadUserInfo(int UserID)
        {
            _User = clsUser.Find(UserID);
            if (_User == null)
            {
                ResetUserInfo();
                MessageBox.Show("No User With ID = " + UserID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillUserInfo();

        }
    }
}
