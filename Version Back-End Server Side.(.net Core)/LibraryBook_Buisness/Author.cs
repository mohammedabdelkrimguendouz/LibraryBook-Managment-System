

using LibraryBook_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook_Buisness
{
    public class Author
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public AuthorDTO authorDTO
        {
            get => new AuthorDTO(this.AuthorID, this.FullName, this.NationalityCountryID, this.BirthDate, this.DeathDate);
        }
        public int AuthorID { get; set; }
        public string FullName { get; set; }
        public int NationalityCountryID { get; set; }
        public Country NationalityCountryInfo;
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }

        public int NumberOfBooks
        {
            get => AuthorData.GetNumberOfBooksForAuthor(this.AuthorID);
        }
        public Author(AuthorDTO authorDTO, enMode CreationMode = enMode.AddNew)
        {
            this.AuthorID = authorDTO.AuthorID;
            this.FullName = authorDTO.FullName;
            this.NationalityCountryID = authorDTO.NationalityCountryID;
            this.NationalityCountryInfo=Country.Find(authorDTO.NationalityCountryID);
            this.BirthDate = authorDTO.BirthDate;
            this.DeathDate = authorDTO.DeathDate
            ;
            Mode = CreationMode;
        }

        public static Author Find(int AuthorID)
        {

            AuthorDTO authorDTO = AuthorData.GetAuthorInfoByID(AuthorID);

            if (authorDTO != null)
            {
                return new Author(authorDTO, enMode.Update);
            }
            return null;

        }

        private bool _AddNewAuthor()
        {
            this.AuthorID = AuthorData.AddNewAuthor(this.authorDTO);
            return (this.AuthorID != -1);
        }

        private bool _UpdateAuthor()
        {
            return AuthorData.UpdateAuthor(this.authorDTO);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewAuthor())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateAuthor();
            }
            return false;
        }

        public static bool DeleteAuthor(int AuthorID)
        {
            return AuthorData.DeleteAuthor(AuthorID);
        }

        public static List<AuthorsListDTO> GetAllAuthors()
        {
            return AuthorData.GetAllAuthors();
        }

        public static bool IsAuthorExist(int AuthorID)
        {
            return AuthorData.IsAuthorExistByID(AuthorID);
        }

    }
}
