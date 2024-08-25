using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBook.Fines
{
    public partial class frmShowFineInfo : Form
    {
        private int _FineID = -1;
        public frmShowFineInfo(int fineID)
        {
            InitializeComponent();
            _FineID = fineID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowFineInfo_Load(object sender, EventArgs e)
        {
            ctrlFineInfo1.LoadFineInfo(_FineID);
        }
    }
}
