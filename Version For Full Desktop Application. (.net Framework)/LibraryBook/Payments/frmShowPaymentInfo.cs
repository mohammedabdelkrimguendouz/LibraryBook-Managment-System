﻿using System;
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
    public partial class frmShowPaymentInfo : Form
    {
        private int _PaymentID = -1;
        public frmShowPaymentInfo(int paymentID)
        {
            InitializeComponent();
            _PaymentID = paymentID;
        }

        private void frmShowPaymentInfo_Load(object sender, EventArgs e)
        {
            ctrlPaymentInfo1.LoadPaymentInfo(_PaymentID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
