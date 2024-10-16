
using DVLD_Buisness;
using LibraryBook_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook_Buisness
{
    public class clsAuthor
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        public int AuthorID { get; set; }
        public string FullName { get; set; }
        public int NationalityCountryID { get; set; }
        public clsCountry NationalityCountryInfo;
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }

        public int NumberOfBooks
        {
            get => clsAuthorData.GetNumberOfBooksForAuthor(this.AuthorID);
        }

        private clsAuthor(int AuthorID, string FullName, int NationalityCountryID, DateTime BirthDate, DateTime? DeathDate)
        {
            this.AuthorID = AuthorID;
            this.FullName = FullName;
            this.NationalityCountryID = NationalityCountryID;
            this.NationalityCountryInfo = clsCountry.Find(NationalityCountryID);
            this.BirthDate = BirthDate;
            this.DeathDate = DeathDate;
            Mode = enMode.Update;
        }

        public clsAuthor()
        {
            AuthorID = -1;
            FullName = "";
            NationalityCountryID = -1;
            BirthDate = DateTime.Now;
            DeathDate = null;
            Mode = enMode.AddNew;
        }

        public static clsAuthor Find(int AuthorID)
        {

            string FullName = ""; int NationalityCountryID = -1; DateTime BirthDate = DateTime.Now; DateTime? DeathDate = null;

            if (clsAuthorData.GetAuthorInfoByID( AuthorID, ref FullName, ref NationalityCountryID, ref BirthDate, ref DeathDate))
            {
                return new clsAuthor(AuthorID, FullName, NationalityCountryID, BirthDate, DeathDate);

            }
            return null;

        }

        private bool _AddNewAuthor()
        {
           this.AuthorID = clsAuthorData.AddNewAuthor(FullName, NationalityCountryID, BirthDate, DeathDate);
            return (this.AuthorID != -1);

        }

        private bool _UpdateAuthor()
        {
            return clsAuthorData.UpdateAuthor(AuthorID, FullName, NationalityCountryID, BirthDate, DeathDate);
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
            return clsAuthorData.DeleteAuthor(AuthorID);
        }

        public static DataTable GetAllAuthors()
        {
            return clsAuthorData.GetAllAuthors();
        }

        public static bool IsAuthorExist(int AuthorID)
        {
            return clsAuthorData.IsAuthorExist(AuthorID);
        }
    }
}
