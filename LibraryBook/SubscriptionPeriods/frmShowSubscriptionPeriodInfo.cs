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
    public partial class frmShowSubscriptionPeriodInfo : Form
    {
        private int _SubscriptionPeriodID = -1;
        public frmShowSubscriptionPeriodInfo(int subscriptionPeriodID)
        {
            InitializeComponent();
            _SubscriptionPeriodID = subscriptionPeriodID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowSubscriptionPeriodInfo_Load(object sender, EventArgs e)
        {
            ctrlSubscriptionPeriodCardInfo1.LoadSubscriptionPeriodInfo(_SubscriptionPeriodID);
        }
    }
}
