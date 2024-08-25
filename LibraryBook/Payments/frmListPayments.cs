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

namespace LibraryBook.Payments
{
    public partial class frmListPayments : Form
    {
        private static DataTable _dtAllPayments;
        public frmListPayments()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListPayments_Load(object sender, EventArgs e)
        {
            _dtAllPayments = clsPayment.GetAllPayments();
            dgvListPayments.DataSource = _dtAllPayments;
            lblRecordsCount.Text = dgvListPayments.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
            if (dgvListPayments.Rows.Count > 0)
            {
                dgvListPayments.Columns["PaymentID"].HeaderText = "Payment ID";
                dgvListPayments.Columns["PaymentID"].Width = 65;


                dgvListPayments.Columns["PersonID"].HeaderText = "Person ID";
                dgvListPayments.Columns["PersonID"].Width = 65;

                dgvListPayments.Columns["LibraryCardNumber"].HeaderText = "Card Number";
                dgvListPayments.Columns["LibraryCardNumber"].Width = 240;

               
                dgvListPayments.Columns["FullName"].HeaderText = "Full Name";
                dgvListPayments.Columns["FullName"].Width = 120;

                dgvListPayments.Columns["PaymentDate"].HeaderText = "Payment Date";
                dgvListPayments.Columns["PaymentDate"].Width = 120;


                dgvListPayments.Columns["PaymentAmount"].HeaderText = "Amount";
                dgvListPayments.Columns["PaymentAmount"].Width = 85;

              

                dgvListPayments.Columns["PaymentReason"].HeaderText = "Payment Reason";
                dgvListPayments.Columns["PaymentReason"].Width = 100;
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Person ID" || cbFilter.Text == "Payment ID")
                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPaymentReason.Visible = (cbFilter.Text == "Payment Reason");
            if (cbPaymentReason.Visible)
                cbPaymentReason.SelectedIndex = 0;

            txtFilterValue.Visible = (!cbPaymentReason.Visible) && (cbFilter.Text != "None");
            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }

            _dtAllPayments.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvListPayments.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilter.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "Payment ID":
                    FilterColumn = "PaymentID";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Card Number":
                    FilterColumn = "LibraryCardNumber";
                    break;
                case "Payment Date":
                    FilterColumn = "PaymentDate";
                    break;
                case "Amount":
                    FilterColumn = "PaymentAmount";
                    break;

            }
            if (txtFilterValue.Text.Trim() == "")
                _dtAllPayments.DefaultView.RowFilter = "";
            else if (FilterColumn == "PersonID" || FilterColumn == "PaymentID")
                _dtAllPayments.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllPayments.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            lblRecordsCount.Text = dgvListPayments.Rows.Count.ToString();
        }

        private void cbPaymentReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterIColumn = "PaymentReason";
            string FilterValue = cbPaymentReason.Text;
           
            if (cbPaymentReason.Text == "All")
                _dtAllPayments.DefaultView.RowFilter = "";
            else
                _dtAllPayments.DefaultView.RowFilter = string.Format("[{0}]='{1}'", FilterIColumn, FilterValue);
            lblRecordsCount.Text = dgvListPayments.Rows.Count.ToString();
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PaymentID = (int)dgvListPayments.CurrentRow.Cells[0].Value;
            frmShowPaymentInfo frm = new frmShowPaymentInfo(PaymentID);
            frm.ShowDialog();
        }
    }
}
