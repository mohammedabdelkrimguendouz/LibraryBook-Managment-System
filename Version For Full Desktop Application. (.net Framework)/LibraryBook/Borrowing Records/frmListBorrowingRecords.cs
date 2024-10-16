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

namespace LibraryBook.Borrowing_Records
{
    public partial class frmListBorrowingRecords : Form
    {
        private static DataTable _dtAllBorrowingRecords;
        private int _PageNumber = 1;

        private enum enAfterChangePage { AfterLoad = 0, AfterNext = 1, AfterPrev = 2, AfterAdd = 3, AfterDelete = 4 }
        private enAfterChangePage _AfterChangePage = enAfterChangePage.AfterLoad;
        public frmListBorrowingRecords()
        {
            InitializeComponent();
        }
        private void _HandelPages()
        {
            switch (_AfterChangePage)
            {
                case enAfterChangePage.AfterLoad:
                    _PageNumber = 1;
                    btnPrev.Enabled = false;
                    lblPageNumber.Text = _PageNumber.ToString();
                    _ReferchListBorrowingRecords();
                    btnNext.Enabled = (clsBorrowingRecord.GetAllBorrowingRecordsForPageNumber(_PageNumber + 1)).Rows.Count > 0;
                    break;
                case enAfterChangePage.AfterNext:
                    _PageNumber = _PageNumber + 1;
                    lblPageNumber.Text = _PageNumber.ToString();
                    btnPrev.Enabled = true;
                    _ReferchListBorrowingRecords();
                    btnNext.Enabled = (clsBorrowingRecord.GetAllBorrowingRecordsForPageNumber(_PageNumber + 1)).Rows.Count > 0;
                    break;
                case enAfterChangePage.AfterPrev:
                    _PageNumber -= 1;
                    if (_PageNumber == 1)
                        btnPrev.Enabled = false;
                    lblPageNumber.Text = _PageNumber.ToString();
                    btnNext.Enabled = true;
                    _ReferchListBorrowingRecords();
                    break;
                case enAfterChangePage.AfterAdd:
                    btnNext.Enabled = (clsBorrowingRecord.GetAllBorrowingRecordsForPageNumber(_PageNumber + 1)).Rows.Count > 0;
                    break;
                case enAfterChangePage.AfterDelete:
                    bool IsCurrentPageExist = (clsBorrowingRecord.GetAllBorrowingRecordsForPageNumber(_PageNumber).Rows.Count) > 0;
                    if (!IsCurrentPageExist)
                    {
                        btnNext.Enabled = false;

                        if (_PageNumber != 1)
                        {
                            _PageNumber -= 1;
                            lblPageNumber.Text = _PageNumber.ToString();
                            _ReferchListBorrowingRecords();
                        }
                        else
                            btnPrev.Enabled = false;

                    }
                    else
                    {
                        bool IsNextPageExist = (clsBorrowingRecord.GetAllBorrowingRecordsForPageNumber(_PageNumber + 1)).Rows.Count > 0;

                        btnNext.Enabled = IsNextPageExist;
                        if (_PageNumber == 1)
                            btnPrev.Enabled = false;
                    }
                    break;
            }
        }

        private void _ReferchListBorrowingRecords()
        {
            
            _dtAllBorrowingRecords = clsBorrowingRecord.GetAllBorrowingRecordsForPageNumber(_PageNumber);
            dgvListBorrowingRecords.DataSource = _dtAllBorrowingRecords;
            lblRecordsCount.Text = dgvListBorrowingRecords.Rows.Count.ToString();

            if (dgvListBorrowingRecords.Rows.Count > 0)
            {
                dgvListBorrowingRecords.Columns["BorrowingRecordID"].HeaderText = "B.Record ID";
                dgvListBorrowingRecords.Columns["BorrowingRecordID"].Width = 90;

                dgvListBorrowingRecords.Columns["PersonID"].HeaderText = "Person ID";
                dgvListBorrowingRecords.Columns["PersonID"].Width = 90;

                dgvListBorrowingRecords.Columns["LibraryCardNumber"].HeaderText = "Card Number";
                dgvListBorrowingRecords.Columns["LibraryCardNumber"].Width = 240;



                dgvListBorrowingRecords.Columns["FullName"].HeaderText = "Full Name";
                dgvListBorrowingRecords.Columns["FullName"].Width = 130;


                dgvListBorrowingRecords.Columns["BookID"].HeaderText = "Book ID";
                dgvListBorrowingRecords.Columns["BookID"].Width = 90;


                dgvListBorrowingRecords.Columns["ISBN"].HeaderText = "ISBN";
                dgvListBorrowingRecords.Columns["ISBN"].Width = 130;

                dgvListBorrowingRecords.Columns["Title"].HeaderText = "Title";
                dgvListBorrowingRecords.Columns["Title"].Width = 130;

                dgvListBorrowingRecords.Columns["BorrowingDate"].HeaderText = "Borrowing Date";
                dgvListBorrowingRecords.Columns["BorrowingDate"].Width = 100;
            }
            cbFilter.SelectedIndex = 0;
            cbFilter_SelectedIndexChanged(null, null);
        }

        private void frmBorrowingRecords_Load(object sender, EventArgs e)
        {
            _AfterChangePage = enAfterChangePage.AfterLoad;
            _HandelPages();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _AfterChangePage = enAfterChangePage.AfterNext;
            _HandelPages();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _AfterChangePage = enAfterChangePage.AfterPrev;
            _HandelPages();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BorrowingRecordID = (int)dgvListBorrowingRecords.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure do you want to delete Borrowing Record [" + BorrowingRecordID + "]", "Confirm Delete", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            

            if (!clsBorrowingRecord.DeleteBorrowingRecord(BorrowingRecordID))
            {
                MessageBox.Show("Borrowing Record Was not deleted because it has data linked to it", "Error Delete", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(" Deleted Successfully", "Successful", MessageBoxButtons.OK,
               MessageBoxIcon.Information);

            _ReferchListBorrowingRecords();

            _AfterChangePage = enAfterChangePage.AfterDelete;
            _HandelPages();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BorrowingRecordID = (int)dgvListBorrowingRecords.CurrentRow.Cells[0].Value;
            frmAddEditBorrowingRecord frm=new frmAddEditBorrowingRecord(BorrowingRecordID);
            frm.ShowDialog();
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BorrowingRecordID = (int)dgvListBorrowingRecords.CurrentRow.Cells[0].Value;
            frmShowBorrowinRecordInfo frm = new frmShowBorrowinRecordInfo(BorrowingRecordID);
            frm.ShowDialog();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditBorrowingRecord frm = new frmAddEditBorrowingRecord();
            frm.ShowDialog();

            _AfterChangePage = enAfterChangePage.AfterAdd;
            _HandelPages();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Person ID" || cbFilter.Text == "Book ID" ||
               cbFilter.Text == "B.Record ID")

                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtfilterValue.Visible = (cbFilter.Text != "None");
            if (txtfilterValue.Visible)
            {
                txtfilterValue.Text = "";
                txtfilterValue.Focus();
            }


            _dtAllBorrowingRecords.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvListBorrowingRecords.Rows.Count.ToString();
        }

        private void txtfilterValue_TextChanged(object sender, EventArgs e)
        {
           
            string FilterColumn = "";
            switch (cbFilter.Text)
            {
                case "B.Record ID":
                    FilterColumn = "BorrowingRecordID";
                    break;
                case "Person ID":
                    FilterColumn = "GuestID";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Card Number":
                    FilterColumn = "LibraryCardNumber";
                    break;
                case "Book ID":
                    FilterColumn = "BookID";
                    break;
                case "ISBN":
                    FilterColumn = "ISBN";
                    break;
                case "Title":
                    FilterColumn = "Title";
                    break;
            }
            if (txtfilterValue.Text.Trim() == "")
                _dtAllBorrowingRecords.DefaultView.RowFilter = "";
            else if (FilterColumn == "BorrowingRecordID" || FilterColumn == "BookID" ||
                FilterColumn == "PersonID")
                _dtAllBorrowingRecords.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtfilterValue.Text.Trim());
            else
                _dtAllBorrowingRecords.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtfilterValue.Text.Trim());
            lblRecordsCount.Text = dgvListBorrowingRecords.Rows.Count.ToString();
        }

        private void cmsListBorrowingRecords_Opening(object sender, CancelEventArgs e)
        {
            int BorrowingRecordID = (int)dgvListBorrowingRecords.CurrentRow.Cells[0].Value;
            clsBorrowingRecord BorrowingRecord =clsBorrowingRecord.Find(BorrowingRecordID);
            if(BorrowingRecord == null) 
                return;
            deleteToolStripMenuItem.Enabled = (BorrowingRecord.ActualReturnDate != null);
        }
    }
}
