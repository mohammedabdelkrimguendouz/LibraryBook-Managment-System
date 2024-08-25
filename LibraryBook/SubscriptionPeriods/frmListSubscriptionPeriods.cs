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

namespace LibraryBook.SubscriptionPeriods
{
    public partial class frmListSubscriptionPeriods : Form
    {
        private static DataTable _dtAllSubscriptionPeriods;
        public frmListSubscriptionPeriods()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListSubscriptionPeriods_Load(object sender, EventArgs e)
        {
            _dtAllSubscriptionPeriods = clsSubscriptionPeriod.GetAllSubscriptionPeriods();
            dgvListSubscriptionPeriods.DataSource = _dtAllSubscriptionPeriods;
            lblRecordsCount.Text = dgvListSubscriptionPeriods.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
            if (dgvListSubscriptionPeriods.Rows.Count > 0)
            {
                dgvListSubscriptionPeriods.Columns["SubscriptionPeriodID"].HeaderText = "S.Period ID";
                dgvListSubscriptionPeriods.Columns["SubscriptionPeriodID"].Width = 75;


                dgvListSubscriptionPeriods.Columns["PersonID"].HeaderText = "Person ID";
                dgvListSubscriptionPeriods.Columns["PersonID"].Width = 75;

                dgvListSubscriptionPeriods.Columns["LibraryCardNumber"].HeaderText = "Card Number";
                dgvListSubscriptionPeriods.Columns["LibraryCardNumber"].Width = 243;

                dgvListSubscriptionPeriods.Columns["FullName"].HeaderText = "Full Name";
                dgvListSubscriptionPeriods.Columns["FullName"].Width = 125;

                dgvListSubscriptionPeriods.Columns["StartDate"].HeaderText = "Start Date";
                dgvListSubscriptionPeriods.Columns["StartDate"].Width = 90;

                

                dgvListSubscriptionPeriods.Columns["EndDate"].HeaderText = "End Date";
                dgvListSubscriptionPeriods.Columns["EndDate"].Width = 90;

                

                dgvListSubscriptionPeriods.Columns["Status"].HeaderText = "Status";
                dgvListSubscriptionPeriods.Columns["Status"].Width = 90;
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Person ID" || cbFilter.Text == "SubscriptionPeriod ID")
                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbStatus.Visible = (cbFilter.Text == "Status");
            if (cbStatus.Visible)
                cbStatus.SelectedIndex = 0;

            txtFilterValue.Visible = (!cbStatus.Visible) && (cbFilter.Text != "None");
            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }

            _dtAllSubscriptionPeriods.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvListSubscriptionPeriods.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilter.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "SubscriptionPeriod ID":
                    FilterColumn = "SubscriptionPeriodID";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Card Number":
                    FilterColumn = "LibraryCardNumber";
                    break;

            }
            if (txtFilterValue.Text.Trim() == "")
                _dtAllSubscriptionPeriods.DefaultView.RowFilter = "";
            else if (FilterColumn == "PersonID" || FilterColumn == "SubscriptionPeriodID")
                _dtAllSubscriptionPeriods.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllSubscriptionPeriods.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            lblRecordsCount.Text = dgvListSubscriptionPeriods.Rows.Count.ToString();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterIColumn = "Status";
            string FilterValue = cbStatus.Text.Trim() ;
           
            if (cbStatus.Text == "All")
                _dtAllSubscriptionPeriods.DefaultView.RowFilter = "";
            else
                _dtAllSubscriptionPeriods.DefaultView.RowFilter = string.Format("[{0}]='{1}'", FilterIColumn, FilterValue);
            lblRecordsCount.Text = dgvListSubscriptionPeriods.Rows.Count.ToString();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditSubscriptionPeriod frm = new frmAddEditSubscriptionPeriod();
            frm.ShowDialog();
            frmListSubscriptionPeriods_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SubscriptionPeriodID = (int)dgvListSubscriptionPeriods.CurrentRow.Cells[0].Value;
            frmAddEditSubscriptionPeriod frm = new frmAddEditSubscriptionPeriod(SubscriptionPeriodID);
            frm.ShowDialog();
            frmListSubscriptionPeriods_Load(null, null);
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SubscriptionPeriodID = (int)dgvListSubscriptionPeriods.CurrentRow.Cells[0].Value;
            frmShowSubscriptionPeriodInfo frm = new frmShowSubscriptionPeriodInfo(SubscriptionPeriodID);
            frm.ShowDialog();
            frmListSubscriptionPeriods_Load(null, null);
        }

        private void cancellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SubscriptionPeriodID = (int)dgvListSubscriptionPeriods.CurrentRow.Cells[0].Value;
            clsSubscriptionPeriod SubscriptionPeriod = clsSubscriptionPeriod.Find(SubscriptionPeriodID);
            if (SubscriptionPeriod == null)
                return;

            if (SubscriptionPeriod.SetCancel())
            {
                MessageBox.Show("Cancel SubscriptionPeriod Successfully ", "Saved",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListSubscriptionPeriods_Load(null, null);
                return;
            }

            MessageBox.Show(" is not Cancel SubscriptionPeriod  Successfully ", "Error ",
          MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmsListSubscriptionPeriods_Opening(object sender, CancelEventArgs e)
        {
            string Status = (string)dgvListSubscriptionPeriods.CurrentRow.Cells[6].Value;

            DateTime StartDate=(DateTime)dgvListSubscriptionPeriods.CurrentRow.Cells[4].Value;



            cancellToolStripMenuItem.Enabled = (Status == "Active") &&
                (clsUtil.GetDaysDifference(StartDate,DateTime.Now) <= clsSetting.DefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod);

            editToolStripMenuItem.Enabled = cancellToolStripMenuItem.Enabled;
        }
    }
}
