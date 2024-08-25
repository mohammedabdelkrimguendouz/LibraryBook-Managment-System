using LibraryBook_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook_Buisness
{
    public class clsBook
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        public int BookID { get; set; }
        public int GenreID { get; set; }
        public clsGenre GenreInfo;
        public string Title { get; set; }
        public int PagesNumber { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
       

        public string  CoverImage { get; set; }
        public string AdditionalDetails { get; set; }

        public int NumberOfAuthors
        {
            get => clsBookData.GetNumberOfAuthorsForBook(this.BookID);
        }

      

        public int NumberOfCopies
        {
            get => clsBookData.GetNumberOfCopiesForBook(this.BookID);
        }




        private clsBook(int BookID, int GenreID, string Title, int PagesNumber, string ISBN, DateTime PublicationDate, string CoverImage, string AdditionalDetails)
        {
            this.BookID = BookID;
            this.GenreID = GenreID;
            this.GenreInfo = clsGenre.Find(GenreID);
            this.Title = Title;
            this.PagesNumber = PagesNumber;
            this.ISBN = ISBN;
            this.PublicationDate = PublicationDate;
            
            this.CoverImage = CoverImage;
            this.AdditionalDetails = AdditionalDetails;
            Mode = enMode.Update;
        }

        public clsBook()
        {
            BookID = -1;
            GenreID = -1;
            Title = "";
            PagesNumber = -1;
            ISBN = "";
            PublicationDate = DateTime.Now;
            
            CoverImage = "";
            AdditionalDetails = "";
            Mode = enMode.AddNew;
        }

        public static clsBook Find(int BookID)
        {

            int GenreID = -1; string Title = ""; int PagesNumber = -1; string ISBN = ""; DateTime PublicationDate = DateTime.Now; string CoverImage = "",  AdditionalDetails = "";

            if (clsBookData.GetBookInfoByID( BookID, ref GenreID, ref Title, ref PagesNumber, ref ISBN, ref PublicationDate, ref CoverImage, ref AdditionalDetails))
            {
                return new clsBook(BookID, GenreID, Title, PagesNumber, ISBN, PublicationDate, CoverImage, AdditionalDetails);

            }
            return null;

        }

        public static clsBook Find(string ISBN)
        {

            int GenreID = -1; string Title = ""; int PagesNumber = -1; int BookID = -1; DateTime PublicationDate = DateTime.Now; string CoverImage = "", AdditionalDetails = "";

            if (clsBookData.GetBookInfoByISBN(ISBN,ref BookID, ref GenreID, ref Title, ref PagesNumber, ref PublicationDate, ref CoverImage, ref AdditionalDetails))
            {
                return new clsBook(BookID, GenreID, Title, PagesNumber, ISBN, PublicationDate, CoverImage, AdditionalDetails);

            }
            return null;

        }

        private bool _AddNewBook()
        {
            this.BookID = clsBookData.AddNewBook(GenreID, Title, PagesNumber, ISBN, PublicationDate, CoverImage, AdditionalDetails);


            return (this.BookID != -1);

        }

        private bool _UpdateBook()
        {
            return clsBookData.UpdateBook(BookID, GenreID, Title, PagesNumber, ISBN, PublicationDate, CoverImage, AdditionalDetails);


        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBook())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateBook();
            }
            return false;
        }

        public static bool DeleteBook(int BookID)
        {
            return clsBookData.DeleteBook(BookID);
        }

        public static DataTable GetAllBooks()
        {
            return clsBookData.GetAllBooks();
        }

        public static bool IsBookExist(int BookID)
        {
            return clsBookData.IsBookExist(BookID);
        }
        public static bool IsBookExist(string ISBN)
        {
            return clsBookData.IsBookExist(ISBN);
        }
    }
}
