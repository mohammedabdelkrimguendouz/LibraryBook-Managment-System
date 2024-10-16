using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBook.Books.controls
{
    public partial class frmShowBookCopyInfo : Form
    {
        private int _BookCopyID = -1;
        public frmShowBookCopyInfo(int bookCopyID)
        {
            InitializeComponent();
            _BookCopyID = bookCopyID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowBookCopyInfo_Load(object sender, EventArgs e)
        {
            ctrlBookCopyInfo1.LoadBookCopyInfo(_BookCopyID);
        }
    }
}
