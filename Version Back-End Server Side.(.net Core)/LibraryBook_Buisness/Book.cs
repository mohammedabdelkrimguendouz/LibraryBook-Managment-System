using LibraryBook_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook_Buisness
{
    public class Book
    {

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        public BookDTO bookDTO
        {
            get => new BookDTO(this.BookID, this.GenreID, this.Title, this.PagesNumber, this.ISBN, this.PublicationDate, this.CoverImage, this.AdditionalDetails, this.Price);
        }
        public int BookID { get; set; }
        public int GenreID { get; set; }
        public Genre GenreInfo { get; set; }
        public string Title { get; set; }
        public int PagesNumber { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
        public string? CoverImage { get; set; }
        public string? AdditionalDetails { get; set; }
        public decimal? Price { get; set; }

        public int NumberOfAuthors
        {
            get => BookData.GetNumberOfAuthorsForBook(this.BookID);
        }



        public int NumberOfCopies
        {
            get => BookData.GetNumberOfCopiesForBook(this.BookID);
        }

        public Book(BookDTO bookDTO, enMode CreationMode = enMode.AddNew)
        {
            this.BookID = bookDTO.BookID;
            this.GenreID = bookDTO.GenreID;
            this.GenreInfo = Genre.Find(bookDTO.GenreID);  
            this.Title = bookDTO.Title;
            this.PagesNumber = bookDTO.PagesNumber;
            this.ISBN = bookDTO.ISBN;
            this.PublicationDate = bookDTO.PublicationDate;
            this.CoverImage = bookDTO.CoverImage;
            this.AdditionalDetails = bookDTO.AdditionalDetails;
            this.Price = bookDTO.Price
            ;
            Mode = CreationMode;
        }

        public static Book Find(int BookID)
        {

            BookDTO bookDTO = BookData.GetBookInfoByID(BookID);

            if (bookDTO != null)
            {
                return new Book(bookDTO, enMode.Update);
            }
            return null;

        }
        public static Book Find(string ISBN)
        {

            BookDTO bookDTO = BookData.GetBookInfoByISBN(ISBN);

            if (bookDTO != null)
            {
                return new Book(bookDTO, enMode.Update);
            }
            return null;

        }

        private bool _AddNewBook()
        {
            this.BookID = BookData.AddNewBook(this.bookDTO);
            return (this.BookID != -1);
        }

        private bool _UpdateBook()
        {
            return BookData.UpdateBook(this.bookDTO);
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
            return BookData.DeleteBook(BookID);
        }

        public static List<BooksListDTO> GetAllBooks()
        {
            return BookData.GetAllBooks();
        }

        public static bool IsBookExist(int BookID)
        {
            return BookData.IsBookExistByID(BookID);
        }


       




     

        

        
        public static bool IsBookExist(string ISBN)
        {
            return BookData.IsBookExist(ISBN);
        }
    }
}
