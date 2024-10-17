using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using Microsoft.Data.SqlClient;

namespace LibraryBook_DataAccess
{
    public class LanguageDTO
    {
        public int LanguageID { get; set; }
        public string LanguageName { get; set; }

        public LanguageDTO(int LanguageID, string LanguageName)
        {
            this.LanguageID = LanguageID;
            this.LanguageName = LanguageName;
        }

    }
    public class LanguageData
    {
       

        public static LanguageDTO GetLanguageInfoByName(string LanguageName)
        {
            LanguageDTO languageDTO = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetLanguageInfoByName", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@LanguageName", LanguageName);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {

                                languageDTO = new LanguageDTO(Reader.GetInt32(Reader.GetOrdinal("LanguageID")),
Reader.GetString(Reader.GetOrdinal("LanguageName"))
                                 );

                            }
                            else
                                languageDTO = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                languageDTO = null;
            }
            return languageDTO;
        }

        public static List<LanguageDTO> GetAllLanguages()
        {
            List<LanguageDTO> ListLanguages = new List<LanguageDTO>();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetAllLanguages", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                ListLanguages.Add
                                   (
                                      new LanguageDTO
                                      (
                                         Reader.GetInt32(Reader.GetOrdinal("LanguageID")),
Reader.GetString(Reader.GetOrdinal("LanguageName"))
                                      )
                                   );
                            }
                        }


                    }
                }
            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);

            }

            return ListLanguages;
        }

       
        public static LanguageDTO GetLanguageInfoByID(int LanguageID)
        {
            LanguageDTO languageDTO = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetLanguageInfoByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@LanguageID", LanguageID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {

                                languageDTO = new LanguageDTO(Reader.GetInt32(Reader.GetOrdinal("LanguageID")),
Reader.GetString(Reader.GetOrdinal("LanguageName"))
                                 );

                            }
                            else
                                languageDTO = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                languageDTO = null;
            }
            return languageDTO;

        }




        public static List<LanguageDTO> GetAllLanguagesForAllBookCopiesForBook(int BookID)
        {
            List<LanguageDTO> ListLanguages = new List<LanguageDTO>();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetAllLanguagesForAllBookCopiesForBook", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@BookID", BookID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                ListLanguages.Add
                                   (
                                      new LanguageDTO
                                      (
                                         Reader.GetInt32(Reader.GetOrdinal("LanguageID")),
Reader.GetString(Reader.GetOrdinal("LanguageName"))
                                      )
                                   );
                            }
                        }


                    }
                }
            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);

            }
            return ListLanguages;
        }

    }
}
