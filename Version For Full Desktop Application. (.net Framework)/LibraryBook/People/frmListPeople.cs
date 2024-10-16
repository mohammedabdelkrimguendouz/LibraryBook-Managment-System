using DVLD_Buisness;
using LibraryBook.Contact;
using LibraryBook.Users;
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

namespace LibraryBook.People
{
    public partial class frmListPeople : Form
    {
        private static DataTable _dtAllPeople;
        public frmListPeople()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {


            _dtAllPeople = clsPerson.GetAllPeople();
            dgvListPeople.DataSource = _dtAllPeople;
            lblRecordsCount.Text = dgvListPeople.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
            if (dgvListPeople.Rows.Count > 0)
            {
                

                dgvListPeople.Columns["PersonID"].HeaderText = "Person ID";
                dgvListPeople.Columns["PersonID"].Width = 68;

                dgvListPeople.Columns["NationalNo"].HeaderText = "National No";
                dgvListPeople.Columns["NationalNo"].Width = 130;

                dgvListPeople.Columns["FullName"].HeaderText = "Full Name";
                dgvListPeople.Columns["FullName"].Width = 130;

                dgvListPeople.Columns["Gender"].HeaderText = "Gender";
                dgvListPeople.Columns["Gender"].Width = 50;

                dgvListPeople.Columns["Phone"].HeaderText = "Phone";
                dgvListPeople.Columns["Phone"].Width = 100;

                dgvListPeople.Columns["LibraryCardNumber"].HeaderText = "Card Number";
                dgvListPeople.Columns["LibraryCardNumber"].Width = 240;

                dgvListPeople.Columns["IsActive"].HeaderText = "Is Active";
                dgvListPeople.Columns["IsActive"].Width = 60;
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Person ID")
                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIsActive.Visible = (cbFilter.Text == "Is Active");
            if (cbIsActive.Visible)
                cbIsActive.SelectedIndex = 0;

            cbGender.Visible= (cbFilter.Text == "Gender");
            if (cbGender.Visible)
                cbGender.SelectedIndex = 0;

            txtFilterValue.Visible = (!cbGender.Visible) && (!cbIsActive.Visible) && (cbFilter.Text != "None");
            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }

            _dtAllPeople.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvListPeople.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilter.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Phone":
                    FilterColumn = "Phone";
                    break;
                case "National No":
                    FilterColumn = "NationalNo";
                    break;
                case "Card Number":
                    FilterColumn = "LibraryCardNumber";
                    break;

            }
            if (txtFilterValue.Text.Trim() == "")
                _dtAllPeople.DefaultView.RowFilter = "";
            else if (FilterColumn == "PersonID")
                _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            lblRecordsCount.Text = dgvListPeople.Rows.Count.ToString();
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
                _dtAllPeople.DefaultView.RowFilter = "";
            else
                _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterIColumn, FilterValue);
            lblRecordsCount.Text = dgvListPeople.Rows.Count.ToString();
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterIColumn = "Gender";
            string FilterValue = cbGender.Text.Trim().ToLower() ;
            if (cbGender.Text == "All")
                _dtAllPeople.DefaultView.RowFilter = "";
            else
                _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}]='{1}'", FilterIColumn, FilterValue);
            lblRecordsCount.Text = dgvListPeople.Rows.Count.ToString();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.ShowDialog();
            frmListPeople_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvListPeople.CurrentRow.Cells[0].Value;
            frmAddEditPerson frm = new frmAddEditPerson(PersonID);
            frm.ShowDialog();
            frmListPeople_Load(null, null);
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvListPeople.CurrentRow.Cells[0].Value;
            frmShowPersonInfo frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
            frmListPeople_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvListPeople.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure do you want to delete Person [" + PersonID + "]", "Confirm Delete", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (clsPerson.DeletePerson(PersonID))
            {
                MessageBox.Show("Person Deleted Successfully", "Successful", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                frmListPeople_Load(null, null);
            }
            else
                MessageBox.Show("Person Was not deleted because it has data linked to it", "Error Delete", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvListPeople.CurrentRow.Cells[0].Value;
            clsPerson Person = clsPerson.Find(PersonID);
            if (Person == null)
                return;

            frmSendEmail frm = new frmSendEmail(Person.Email);
            frm.ShowDialog();
        }

        private void cmsListPeople_Opening(object sender, CancelEventArgs e)
        {
            bool IsActive = (bool)dgvListPeople.CurrentRow.Cells[6].Value;
            activeToolStripMenuItem.Enabled = !IsActive;
            inActiveToolStripMenuItem.Enabled = IsActive;
        }

        private void _UpdateStatus(bool NewStatus)
        {
            int PersonID = (int)dgvListPeople.CurrentRow.Cells[0].Value;
            clsPerson Person = clsPerson.Find(PersonID);
            if (Person == null)
                return;

            if (Person.UpdateStatus(NewStatus))
            {
                MessageBox.Show("Data Saved Successfully ", "Saved",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListPeople_Load(null, null);
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
