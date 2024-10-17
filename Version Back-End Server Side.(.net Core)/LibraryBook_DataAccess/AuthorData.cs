
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace LibraryBook_DataAccess
{
    public class AuthorDTO
    {
        public int AuthorID { get; set; }
        public string FullName { get; set; }
        public int NationalityCountryID { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }

        public AuthorDTO(int AuthorID, string FullName, int NationalityCountryID, DateTime BirthDate, DateTime? DeathDate)
        {
            this.AuthorID = AuthorID;
            this.FullName = FullName;
            this.NationalityCountryID = NationalityCountryID;
            this.BirthDate = BirthDate;
            this.DeathDate = DeathDate;
        }

    }

    public class AuthorsListDTO
    {
        public int AuthorID { get; set; }
        public string FullName { get; set; }
        public string CountryName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }

        public AuthorsListDTO(int AuthorID, string FullName, string countryName, DateTime BirthDate, DateTime? DeathDate)
        {
            this.AuthorID = AuthorID;
            this.FullName = FullName;
            this.CountryName = countryName;
            this.BirthDate = BirthDate;
            this.DeathDate = DeathDate;
        }

    }
    public class AuthorData
    {

        public static int AddNewAuthor(AuthorDTO authorDTO)
        {
            int AuthorID = -1;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_AddNewAuthor", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@FullName", authorDTO.FullName);
                        Command.Parameters.AddWithValue("@NationalityCountryID", authorDTO.NationalityCountryID);
                        Command.Parameters.AddWithValue("@BirthDate", authorDTO.BirthDate);
                        if (authorDTO.DeathDate != null)
                            Command.Parameters.AddWithValue("@DeathDate", authorDTO.DeathDate);
                        else
                            Command.Parameters.AddWithValue("@DeathDate", DBNull.Value);


                        SqlParameter outputIdParam = new SqlParameter("AuthorID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIdParam);


                        Command.ExecuteNonQuery();

                        AuthorID = (int)outputIdParam.Value;

                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                AuthorID = -1;
            }
            return AuthorID;
        }

        public static bool UpdateAuthor(AuthorDTO authorDTO)
        {
            int RowsEffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_UpdateAuthor", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@AuthorID", authorDTO.AuthorID);
                        Command.Parameters.AddWithValue("@FullName", authorDTO.FullName);
                        Command.Parameters.AddWithValue("@NationalityCountryID", authorDTO.NationalityCountryID);
                        Command.Parameters.AddWithValue("@BirthDate", authorDTO.BirthDate);
                        if (authorDTO.DeathDate != null)
                            Command.Parameters.AddWithValue("@DeathDate", authorDTO.DeathDate);
                        else
                            Command.Parameters.AddWithValue("@DeathDate", DBNull.Value);


                        SqlParameter RowsEffectedParam = new SqlParameter("@RowsEffected", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(RowsEffectedParam);

                        Command.ExecuteNonQuery();
                        RowsEffected = ((int)RowsEffectedParam.Value);


                    }
                }
            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                RowsEffected = 0;
            }

            return (RowsEffected == 1);
        }

        public static bool DeleteAuthor(int AuthorID)
        {
            int RowsEffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_DeleteAuthor", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@AuthorID", AuthorID);


                        SqlParameter RowsEffectedParam = new SqlParameter("@RowsEffected", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(RowsEffectedParam);

                        Command.ExecuteNonQuery();
                        RowsEffected = ((int)RowsEffectedParam.Value);

                    }
                }
            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                RowsEffected = 0;
            }

            return RowsEffected == 1;
        }

        public static List<AuthorsListDTO> GetAllAuthors()
        {
            List<AuthorsListDTO> ListAuthors = new List<AuthorsListDTO>();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetAllAuthors", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                ListAuthors.Add
                                   (
                                      new AuthorsListDTO
                                      (
                                         Reader.GetInt32(Reader.GetOrdinal("AuthorID")),
Reader.GetString(Reader.GetOrdinal("FullName")),
Reader.GetString(Reader.GetOrdinal("CountryName")),
Reader.GetDateTime(Reader.GetOrdinal("BirthDate")),
Reader.IsDBNull(Reader.GetOrdinal("DeathDate")) ? null : Reader.GetDateTime(Reader.GetOrdinal("DeathDate"))
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

            return ListAuthors;
        }

        public static bool IsAuthorExistByID(int AuthorID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_IsAuthorExistByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@AuthorID", AuthorID);
                        SqlParameter IsFoundParam = new SqlParameter("@IsFound", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(IsFoundParam);

                        Command.ExecuteNonQuery();
                        IsFound = ((int)IsFoundParam.Value == 1);

                    }
                }
            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                IsFound = false;
            }
            return IsFound;
        }

        public static AuthorDTO GetAuthorInfoByID(int AuthorID)
        {
            AuthorDTO authorDTO = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetAuthorInfoByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@AuthorID", AuthorID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {

                                authorDTO = new AuthorDTO(Reader.GetInt32(Reader.GetOrdinal("AuthorID")),
Reader.GetString(Reader.GetOrdinal("FullName")),
Reader.GetInt32(Reader.GetOrdinal("NationalityCountryID")),
Reader.GetDateTime(Reader.GetOrdinal("BirthDate")),
Reader.IsDBNull(Reader.GetOrdinal("DeathDate")) ? null : Reader.GetDateTime(Reader.GetOrdinal("DeathDate"))
                                 );

                            }
                            else
                                authorDTO = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                authorDTO = null;
            }
            return authorDTO;

        }
        public static int GetNumberOfBooksForAuthor(int AuthorID)
        {
            int NumberOfBooksForAuthor = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetNumberOfBooksForAuthor", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@AuthorID", AuthorID);



                        SqlParameter NumberParam = new SqlParameter("@Number", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(NumberParam);

                        Command.ExecuteNonQuery();

                        NumberOfBooksForAuthor = (int)NumberParam.Value;

                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                NumberOfBooksForAuthor = 0;
            }
            return NumberOfBooksForAuthor;
        }

    }
}
