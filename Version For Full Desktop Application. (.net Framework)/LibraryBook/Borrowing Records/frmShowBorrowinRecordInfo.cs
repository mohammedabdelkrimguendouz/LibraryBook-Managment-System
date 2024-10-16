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
    public partial class frmShowBorrowinRecordInfo : Form
    {
        private int _BorrowinRecordID = -1;
        public frmShowBorrowinRecordInfo(int borrowinRecordID)
        {
            InitializeComponent();
            _BorrowinRecordID = borrowinRecordID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowBorrowinRecordInfo_Load(object sender, EventArgs e)
        {
            ctrlBorrowingRecordInfo1.LoadBorrowingRecordInfo(_BorrowinRecordID);
        }
    }
}
