using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBook.Authors
{
    public partial class frmShowAuthorInfo : Form
    {
        private int _AuthorID = -1;
        public frmShowAuthorInfo(int AuthorID)
        {
            InitializeComponent();
            this._AuthorID = AuthorID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowAuthorInfo_Load(object sender, EventArgs e)
        {
            ctrlAuthorCardInfo1.LoadAuthorInfo(_AuthorID);
        }
    }
}
