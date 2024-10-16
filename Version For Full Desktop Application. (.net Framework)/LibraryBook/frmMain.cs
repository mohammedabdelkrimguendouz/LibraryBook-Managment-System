using DVLD.Global_Classes;
using LibraryBook.Authors;
using LibraryBook.Books;
using LibraryBook.Borrowing_Records;
using LibraryBook.ConfigurationSettings;
using LibraryBook.Genres;
using LibraryBook.LogIn;
using LibraryBook.Payments;
using LibraryBook.People;
using LibraryBook.Reservations;
using LibraryBook.SubscriptionPeriods;
using LibraryBook.Users;
using LibraryBook_Buisness;
using LibraryFine.Fines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBook
{
    public partial class frmMain : Form
    {
        private frmLogIn _frmLogIn;
        public frmMain(frmLogIn frmLogIn)
        {
            InitializeComponent();
            _frmLogIn = frmLogIn;
        }
 
        private void _CheckReservationStatus()
        {
            clsReservation.CheckReservationStatus();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (clsSetting.IsShowConfigurationSettings)
            {
                Parallel.Invoke(_CheckReservationStatus);
                return;
                
            }
                
            frmConfigurationSettings frm = new frmConfigurationSettings();
            frm.ShowDialog();
            clsSetting.IsShowConfigurationSettings = true;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPeople frm = new frmListPeople();
            frm.ShowDialog();
        }

        private void subscriptionPeriodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListSubscriptionPeriods frm=new frmListSubscriptionPeriods();
            frm.ShowDialog();
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPayments frm=new frmListPayments();
            frm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListUsers frm=new frmListUsers();
            frm.ShowDialog();
        }

        private void configurationSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfigurationSettings frm=new frmConfigurationSettings();
            frm.ShowDialog();
        }

        private void currentUseRInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm = new frmShowUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void singOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogIn.Show();
        }

        private void accountSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditBook frm = new frmAddEditBook();
            frm.ShowDialog();
        }

        private void listBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBooks frm = new frmListBooks();
            frm.ShowDialog();
        }

        private void manageGenresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListGenres frm = new frmListGenres();
            frm.ShowDialog();
        }

        private void manageAuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListAuthors frm = new frmListAuthors();
            frm.ShowDialog();
        }

        private void manageBorrowingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBorrowingRecords frm = new frmListBorrowingRecords();    
            frm.ShowDialog();
        }

        private void manageFinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListFines frm = new frmListFines();
            frm.ShowDialog();
        }

        private void manageReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListReservations frm = new frmListReservations();
            frm.ShowDialog();
        }
    }
}
