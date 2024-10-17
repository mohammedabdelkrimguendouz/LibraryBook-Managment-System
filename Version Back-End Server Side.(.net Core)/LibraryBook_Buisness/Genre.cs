using LibraryBook_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook_Buisness
{
    public class Genre
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        public GenreDTO genreDTO
        {
            get => new GenreDTO(this.GenreID, this.GenreName, this.Description);
        }
        public int GenreID { get; set; }
        public string GenreName { get; set; }
        public string? Description { get; set; }
        public int NumberOfBooks
        {
            get => GenreData.GetNumberOfBooksForGenre(this.GenreID);
        }

        public Genre(GenreDTO genreDTO, enMode CreationMode = enMode.AddNew)
        {
            this.GenreID = genreDTO.GenreID;
            this.GenreName = genreDTO.GenreName;
            this.Description = genreDTO.Description
            ;
            Mode = CreationMode;
        }

        public static Genre Find(int GenreID)
        {

            GenreDTO genreDTO = GenreData.GetGenreInfoByID(GenreID);

            if (genreDTO != null)
            {
                return new Genre(genreDTO, enMode.Update);
            }
            return null;

        }

        public static Genre Find(string GenreName)
        {

            GenreDTO genreDTO = GenreData.GetGenreInfoByName(GenreName);

            if (genreDTO != null)
            {
                return new Genre(genreDTO, enMode.Update);
            }
            return null;

        }

        private bool _AddNewGenre()
        {
            this.GenreID = GenreData.AddNewGenre(this.genreDTO);
            return (this.GenreID != -1);
        }

        private bool _UpdateGenre()
        {
            return GenreData.UpdateGenre(this.genreDTO);
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
            return GenreData.DeleteGenre(GenreID);
        }

        public static List<GenresListDTO> GetAllGenres()
        {
            return GenreData.GetAllGenres();
        }

        public static bool IsGenreExist(int GenreID)
        {
            return GenreData.IsGenreExistByID(GenreID);
        }

       

       
        

        
        public static bool IsGenreExist(string GenreName)
        {
            return GenreData.IsGenreExistByName(GenreName);
        }
    }
}
