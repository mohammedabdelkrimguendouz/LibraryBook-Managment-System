using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBook.Reservations
{
    public partial class frmShowReservationInfo : Form
    {
        private int _ReservationID = -1;
        public frmShowReservationInfo(int reservationID)
        {
            InitializeComponent();
            _ReservationID = reservationID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowReservationInfo_Load(object sender, EventArgs e)
        {
            ctrlReservationCardInfo1.LoadReservationInfo(_ReservationID);
        }
    }
}
