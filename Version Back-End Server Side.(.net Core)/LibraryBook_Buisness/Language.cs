
using LibraryBook_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook_Buisness
{
    public class Language
    {
       
        public int LanguageID { get; set; }
        public string LanguageName { get; set; }


        private Language(LanguageDTO languageDTO)
        {
            this.LanguageID = languageDTO.LanguageID;
            this.LanguageName = languageDTO.LanguageName
            ;
        }


        public static Language Find(int LanguageID)
        {

            LanguageDTO languageDTO = LanguageData.GetLanguageInfoByID(LanguageID);

            if (languageDTO != null)
            {
                return new Language(languageDTO);
            }
            return null;

        }


        public static Language Find(string LanguageName)
        {
            LanguageDTO languageDTO = LanguageData.GetLanguageInfoByName(LanguageName);

            if (languageDTO != null)
            {
                return new Language(languageDTO);
            }
            return null;


        }

        public static List<LanguageDTO> GetAllLanguages()
        {
            return LanguageData.GetAllLanguages();
        }
        static public List<LanguageDTO> GetAllLanguagesForAllBookCopiesForBook(int BookID)
        {
            return LanguageData.GetAllLanguagesForAllBookCopiesForBook(BookID);
        }
    }
}
