using LibraryBook_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook_Buisness
{
    public class clsGenre
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        public int GenreID { get; set; }
        public string GenreName { get; set; }
        public string Description { get; set; }

        public int NumberOfBooks
        {
            get => clsGenreData.GetNumberOfBooksForGenre(this.GenreID);
        }

        private clsGenre(int GenreID, string GenreName, string Description)
        {
            this.GenreID = GenreID;
            this.GenreName = GenreName;
            this.Description = Description;
            Mode = enMode.Update;
        }

        public clsGenre()
        {
            GenreID = -1;
            GenreName = "";
            Description = "";
            Mode = enMode.AddNew;
        }

        public static clsGenre Find(int GenreID)
        {

            string GenreName = ""; string Description = "";

            if (clsGenreData.GetGenreInfoByID( GenreID, ref GenreName, ref Description))
            {
                return new clsGenre(GenreID, GenreName, Description);

            }
            return null;

        }
        public static clsGenre Find(string GenreName)
        {

            int GenreID = -1; string Description = "";

            if (clsGenreData.GetGenreInfoByName(GenreName,ref GenreID , ref Description))
            {
                return new clsGenre(GenreID, GenreName, Description);

            }
            return null;

        }

        private bool _AddNewGenre()
        {
            this.GenreID = clsGenreData.AddNewGenre(GenreName, Description);


                      return (this.GenreID != -1);

        }

        private bool _UpdateGenre()
        {
            return clsGenreData.UpdateGenre(GenreID, GenreName, Description);


        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewGenre())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateGenre();
            }
            return false;
        }

        public static bool DeleteGenre(int GenreID)
        {
            return clsGenreData.DeleteGenre(GenreID);
        }

        public static DataTable GetAllGenres()
        {
            return clsGenreData.GetAllGenres();
        }

        public static bool IsGenreExist(int GenreID)
        {
            return clsGenreData.IsGenreExist(GenreID);
        }

        public static bool IsGenreExist(string GenreName)
        {
            return clsGenreData.IsGenreExist(GenreName);
        }
    }
}
