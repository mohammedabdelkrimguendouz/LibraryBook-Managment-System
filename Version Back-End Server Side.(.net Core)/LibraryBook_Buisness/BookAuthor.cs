using LibraryBook_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook_Buisness
{
    public class BookAuthor
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        public int BookAuthorID { get; set; }
        public int BookID { get; set; }
        //public clsBook BookInfo;
        public int AuthorID { get; set; }
        //public clsAuthor AuthorInfo;

        private BookAuthor(int BookAuthorID, int BookID, int AuthorID)
        {
            this.BookAuthorID = BookAuthorID;
            this.BookID = BookID;
            //this.BookInfo = clsBook.Find(BookID);
            this.AuthorID = AuthorID;
            //this.AuthorInfo = clsAuthor.Find(AuthorID);
            Mode = enMode.Update;
        }

        public BookAuthor()
        {
            BookAuthorID = -1;
            BookID = -1;
            AuthorID = -1;
            Mode = enMode.AddNew;
        }

        public static BookAuthor Find(int BookAuthorID)
        {

            int  BookID = -1, AuthorID = -1;

            if (BookAuthorData.GetBookAuthorInfoByID( BookAuthorID, ref BookID, ref AuthorID))
            {
                return new BookAuthor(BookAuthorID, BookID, AuthorID);

            }
            return null;

        }

        private bool _AddNewBookAuthor()
        {
            this.BookAuthorID = BookAuthorData.AddNewBookAuthor(BookID, AuthorID);


            return (this.BookAuthorID != -1);

        }

        public bool _UpdateBookAuthor()
        {
            return BookAuthorData.UpdateBookAuthor(BookAuthorID, BookID, AuthorID);


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
            return BookAuthorData.DeleteBookAuthor(BookAuthorID);
        }

        public static DataTable GetAllBookAuthors()
        {
            return BookAuthorData.GetAllBookAuthors();
        }
        public static DataTable GetAllAuthorsForBook(int BookID)
        {
            return BookAuthorData.GetAllAuthorsForBook(BookID);
        }

        public static bool IsBookAuthorExist(int BookAuthorID)
        {
            return BookAuthorData.IsBookAuthorExist(BookAuthorID);
        }
        public static bool IsBookAuthorExist(int BookID,int AuthorID)
        {
            return BookAuthorData.IsBookAuthorExist(BookID, AuthorID);
        }
    }
}
