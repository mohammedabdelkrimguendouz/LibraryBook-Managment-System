using LibraryBook_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook_Buisness
{
    public class clsBookCopy
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        public int BookCopyID { get; set; }
        public int BookID { get; set; }
        public clsBook BookInfo;
        public int LanguageID { get; set; }
        public clsLanguage LanguageInfo;
        public bool AvailabilityStatus { get; set; }

        private clsBookCopy(int BookCopyID, int BookID, int LanguageID, bool AvailabilityStatus)
        {
            this.BookCopyID = BookCopyID;
            this.BookID = BookID;
            this.BookInfo = clsBook.Find(BookID);
            this.LanguageID = LanguageID;
            this.LanguageInfo=clsLanguage.Find(LanguageID);
            this.AvailabilityStatus = AvailabilityStatus;
            Mode = enMode.Update;
        }

        public clsBookCopy()
        {
            BookCopyID = -1;
            BookID = -1;
            LanguageID = -1;
            AvailabilityStatus = false;
            Mode = enMode.AddNew;
        }

        public static clsBookCopy Find(int BookCopyID)
        {

            int BookID = -1; int LanguageID = -1; bool AvailabilityStatus = false;
        
            if (clsBookCopyData.GetBookCopyInfoByID( BookCopyID, ref BookID, ref LanguageID, ref AvailabilityStatus))
            {
                return new clsBookCopy(BookCopyID, BookID, LanguageID, AvailabilityStatus);

            }
            return null;

        }

        private bool _AddNewBookCopy()
        {
            this.BookCopyID = clsBookCopyData.AddNewBookCopy(BookID, LanguageID, AvailabilityStatus);

            return (this.BookCopyID != -1);
        }

        private bool _UpdateBookCopy()
        {
            return clsBookCopyData.UpdateBookCopy(BookCopyID, BookID, LanguageID, AvailabilityStatus);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBookCopy())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateBookCopy();
            }
            return false;
        }

        public static bool DeleteBookCopy(int BookCopyID)
        {
            return clsBookCopyData.DeleteBookCopy(BookCopyID);
        }

        public static DataTable GetAllBookCopies()
        {
            return clsBookCopyData.GetAllBookCopies();
        }

        public static bool IsBookCopyExist(int BookCopyID)
        {
            return clsBookCopyData.IsBookCopyExist(BookCopyID);
        }
        public static DataTable GetAllCopiesForBook(int BookID)
        {
            return clsBookCopyData.GetAllCopiesForBook(BookID);
        }

        public static int GetIDForBookCopyAvailableByBookAndLanguage(int BookID,int LanguageID)
        {
            return clsBookCopyData.GetIDForAnyBookCopyByBookAndLanguage(BookID, LanguageID,true);
        }

        public static int GetIDForBookCopyNotAvailableByBookAndLanguage(int BookID, int LanguageID)
        {
            return clsBookCopyData.GetIDForAnyBookCopyByBookAndLanguage(BookID, LanguageID,false);
        }

       
    }
}
