using DVLD_Buisness;
using DVLD_DataAccess;
using LibraryBook_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook_Buisness
{
    public class clsLanguage
    {
        public int ID { get; set; }
        public string LanguageName { get; set; }

       
        public clsLanguage()
        {
            ID = -1;
            LanguageName = "";
        }

        private clsLanguage(int ID, string LanguageName)
        {
            this.ID = ID;
            this.LanguageName = LanguageName;
        }

        public static clsLanguage Find(int ID)
        {

            string LanguageName = "";

            if (clsLanguageData.GetLanguageInfoByID(ID, ref LanguageName))

                return new clsLanguage(ID, LanguageName);
            else
                return null;

        }

        public static clsLanguage Find(string LanguageName)
        {
            int ID = -1;
            if (clsLanguageData.GetLanguageInfoByName(LanguageName, ref ID))

                return new clsLanguage(ID, LanguageName);
            else
                return null;

        }

        static public DataTable GetAllLanguages()
        {
            return clsLanguageData.GetAllLanguages();
        }
        static public DataTable GetAllLanguagesForAllBookCopiesForBook(int BookID)
        {
            return clsLanguageData.GetAllLanguagesForAllBookCopiesForBook(BookID);
        }
    }
}
