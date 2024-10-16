using LibraryBook.Authors;
using LibraryBook.Books;
using LibraryBook.Books.controls;
using LibraryBook.Borrowing_Records;
using LibraryBook.ConfigurationSettings;
using LibraryBook.Fines;
using LibraryBook.Genres;
using LibraryBook.LogIn;
using LibraryBook.Payments;
using LibraryBook.People;
using LibraryBook.Reservations;
using LibraryBook.SubscriptionPeriods;
using LibraryBook.Users;
using LibraryFine.Fines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBook
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogIn());
        }
    }
}
