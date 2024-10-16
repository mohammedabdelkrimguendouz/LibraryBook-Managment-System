using LibraryBook_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook_Buisness
{
    public class clsBookAuthor
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        public int BookAuthorID { get; set; }
        public int BookID { get; set; }
        public clsBook BookInfo;
        public int AuthorID { get; set; }
        public clsAuthor AuthorInfo;

        private clsBookAuthor(int BookAuthorID, int BookID, int AuthorID)
        {
            this.BookAuthorID = BookAuthorID;
            this.BookID = BookID;
            this.BookInfo = clsBook.Find(BookID);
            this.AuthorID = AuthorID;
            this.AuthorInfo = clsAuthor.Find(AuthorID);
            Mode = enMode.Update;
        }

        public clsBookAuthor()
        {
            BookAuthorID = -1;
            BookID = -1;
            AuthorID = -1;
            Mode = enMode.AddNew;
        }

        public static clsBookAuthor Find(int BookAuthorID)
        {

            int  BookID = -1, AuthorID = -1;

            if (clsBookAuthorData.GetBookAuthorInfoByID( BookAuthorID, ref BookID, ref AuthorID))
            {
                return new clsBookAuthor(BookAuthorID, BookID, AuthorID);

            }
            return null;

        }

        private bool _AddNewBookAuthor()
        {
            this.BookAuthorID = clsBookAuthorData.AddNewBookAuthor(BookID, AuthorID);


            return (this.BookAuthorID != -1);

        }

        public bool _UpdateBookAuthor()
        {
            return clsBookAuthorData.UpdateBookAuthor(BookAuthorID, BookID, AuthorID);


        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBookAuthor())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateBookAuthor();
            }
            return false;
        }

        public static bool DeleteBookAuthor(int BookAuthorID)
        {
            return clsBookAuthorData.DeleteBookAuthor(BookAuthorID);
        }

        public static DataTable GetAllBookAuthors()
        {
            return clsBookAuthorData.GetAllBookAuthors();
        }
        public static DataTable GetAllAuthorsForBook(int BookID)
        {
            return clsBookAuthorData.GetAllAuthorsForBook(BookID);
        }

        public static bool IsBookAuthorExist(int BookAuthorID)
        {
            return clsBookAuthorData.IsBookAuthorExist(BookAuthorID);
        }
        public static bool IsBookAuthorExist(int BookID,int AuthorID)
        {
            return clsBookAuthorData.IsBookAuthorExist(BookID, AuthorID);
        }
    }
}
