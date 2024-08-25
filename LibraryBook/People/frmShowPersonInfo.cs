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
    public partial class frmShowPersonInfo : Form
    {
        public frmShowPersonInfo(int personID)
        {
            InitializeComponent();
            ctrlPersonCardInfo1.LoadPersonInfo(personID);
        }
        public frmShowPersonInfo(string LibraryCardNumber)
        {
            InitializeComponent();
            ctrlPersonCardInfo1.LoadPersonInfo(LibraryCardNumber);
        }

        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
