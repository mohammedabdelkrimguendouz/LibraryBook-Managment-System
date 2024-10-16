using DVLD_Buisness;
using LibraryBook.Contact;
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
    public partial class frmListUsers : Form
    {
        private static DataTable _dtAllUsers;
        public frmListUsers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {

            _dtAllUsers = clsUser.GetAllUsers();
            dgvListUsers.DataSource = _dtAllUsers;
            lblRecordsCount.Text = dgvListUsers.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
            if (dgvListUsers.Rows.Count > 0)
            {
                dgvListUsers.Columns["UserID"].HeaderText = "User ID";
                dgvListUsers.Columns["UserID"].Width = 65;


                dgvListUsers.Columns["PersonID"].HeaderText = "Person ID";
                dgvListUsers.Columns["PersonID"].Width = 65;

                dgvListUsers.Columns["NationalNo"].HeaderText = "National No";
                dgvListUsers.Columns["NationalNo"].Width = 120;

                dgvListUsers.Columns["FullName"].HeaderText = "Full Name";
                dgvListUsers.Columns["FullName"].Width = 120;

                dgvListUsers.Columns["UserName"].HeaderText = "User Name";
                dgvListUsers.Columns["UserName"].Width = 85;

                dgvListUsers.Columns["LibraryCardNumber"].HeaderText = "Card Number";
                dgvListUsers.Columns["LibraryCardNumber"].Width = 240;

                dgvListUsers.Columns["IsActive"].HeaderText = "Is Active";
                dgvListUsers.Columns["IsActive"].Width = 60;
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Person ID" || cbFilter.Text == "User ID")
                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIsActive.Visible = (cbFilter.Text == "Is Active");
            if (cbIsActive.Visible)
                cbIsActive.SelectedIndex = 0;

            txtFilterValue.Visible = (!cbIsActive.Visible) && (cbFilter.Text != "None");
            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }

            _dtAllUsers.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvListUsers.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilter.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "User ID":
                    FilterColumn = "UserID";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "User Name":
                    FilterColumn = "UserName";
                    break;
                case "National No":
                    FilterColumn = "NationalNo";
                    break;
                case "Card Number":
                    FilterColumn = "LibraryCardNumber";
                    break;

            }
            if (txtFilterValue.Text.Trim() == "")
                _dtAllUsers.DefaultView.RowFilter = "";
            else if (FilterColumn == "PersonID" || FilterColumn == "UserID")
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            lblRecordsCount.Text = dgvListUsers.Rows.Count.ToString();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterIColumn = "IsActive";
            string FilterValue = "";
            switch (cbIsActive.Text)
            {
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }
            if (cbIsActive.Text == "All")
                _dtAllUsers.DefaultView.RowFilter = "";
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterIColumn, FilterValue);
            lblRecordsCount.Text = dgvListUsers.Rows.Count.ToString();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvListUsers.CurrentRow.Cells[0].Value;
            frmAddEditUser frm = new frmAddEditUser(UserID);
            frm.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvListUsers.CurrentRow.Cells[0].Value;
            frmShowUserInfo frm = new frmShowUserInfo(UserID);
            frm.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvListUsers.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure do you want to delete User [" + UserID + "]", "Confirm Delete", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            
           if (clsUser.DeleteUser(UserID))
           {
                    MessageBox.Show("User Deleted Successfully", "Successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    frmListUsers_Load(null, null);
           }
           else
                MessageBox.Show("User Was not deleted because it has data linked to it", "Error Delete", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvListUsers.CurrentRow.Cells[0].Value;
            clsUser User = clsUser.Find(UserID);
            if (User == null)
                return;

            frmSendEmail frm = new frmSendEmail(User.PersonInfo.Email);
            frm.ShowDialog();
        }

        private void changePasswordtoolStripMenuItem4_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvListUsers.CurrentRow.Cells[0].Value;
            frmChangePassword frm = new frmChangePassword(UserID);
            frm.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void cmsListUsers_Opening(object sender, CancelEventArgs e)
        {
            bool IsActive = (bool)dgvListUsers.CurrentRow.Cells[6].Value;
            activeToolStripMenuItem.Enabled = !IsActive;
            inActiveToolStripMenuItem.Enabled = IsActive;
        }

        private void _UpdateStatus(bool NewStatus)
        {
            int UserID = (int)dgvListUsers.CurrentRow.Cells[0].Value;
            clsUser User = clsUser.Find(UserID);
            if (User == null)
                return;

            if (User.PersonInfo.UpdateStatus(NewStatus))
            {
                MessageBox.Show("Data Saved Successfully ", "Saved",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListUsers_Load(null, null);
                return;
            }
               
                MessageBox.Show("Data is not Saved Successfully ", "Error ",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _UpdateStatus(true);
        }

        private void inActiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _UpdateStatus(false);
        }
    }
}
