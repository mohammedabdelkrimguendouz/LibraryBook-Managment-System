
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
    public class LibraryCardDTO
    {
        public int LibraryCardID { get; set; }
        public string LibraryCardNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public bool IsActive { get; set; }

        public LibraryCardDTO(int LibraryCardID, string LibraryCardNumber, DateTime IssueDate, bool IsActive)
        {
            this.LibraryCardID = LibraryCardID;
            this.LibraryCardNumber = LibraryCardNumber;
            this.IssueDate = IssueDate;
            this.IsActive = IsActive;
        }

    }
    public class LibraryCardData
    {
        public static int AddNewLibraryCard(LibraryCardDTO librarycardDTO)
        {
            int LibraryCardID = -1;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_AddNewLibraryCard", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@LibraryCardNumber", librarycardDTO.LibraryCardNumber);
                        Command.Parameters.AddWithValue("@IssueDate", librarycardDTO.IssueDate);
                        Command.Parameters.AddWithValue("@IsActive", librarycardDTO.IsActive);


                        SqlParameter outputIdParam = new SqlParameter("LibraryCardID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIdParam);


                        Command.ExecuteNonQuery();

                        LibraryCardID = (int)outputIdParam.Value;

                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                LibraryCardID = -1;
            }
            return LibraryCardID;
        }

        public static bool UpdateLibraryCard(LibraryCardDTO librarycardDTO)
        {
            int RowsEffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_UpdateLibraryCard", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@LibraryCardID", librarycardDTO.LibraryCardID);
                        Command.Parameters.AddWithValue("@LibraryCardNumber", librarycardDTO.LibraryCardNumber);
                        Command.Parameters.AddWithValue("@IssueDate", librarycardDTO.IssueDate);
                        Command.Parameters.AddWithValue("@IsActive", librarycardDTO.IsActive);


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

        public static bool DeleteLibraryCard(int LibraryCardID)
        {
            int RowsEffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_DeleteLibraryCard", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@LibraryCardID", LibraryCardID);


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

        public static List<LibraryCardDTO> GetAllLibraryCards()
        {
            List<LibraryCardDTO> ListLibraryCards = new List<LibraryCardDTO>();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetAllLibraryCards", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                ListLibraryCards.Add
                                   (
                                      new LibraryCardDTO
                                      (
                                         Reader.GetInt32(Reader.GetOrdinal("LibraryCardID")),
Reader.GetString(Reader.GetOrdinal("LibraryCardNumber")),
Reader.GetDateTime(Reader.GetOrdinal("IssueDate")),
Reader.GetBoolean(Reader.GetOrdinal("IsActive"))
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

            return ListLibraryCards;
        }

        public static bool IsLibraryCardExistByID(int LibraryCardID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_IsLibraryCardExistByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@LibraryCardID", LibraryCardID);
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

        public static LibraryCardDTO GetLibraryCardInfoByID(int LibraryCardID)
        {
            LibraryCardDTO librarycardDTO = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetLibraryCardInfoByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@LibraryCardID", LibraryCardID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {

                                librarycardDTO = new LibraryCardDTO(Reader.GetInt32(Reader.GetOrdinal("LibraryCardID")),
Reader.GetString(Reader.GetOrdinal("LibraryCardNumber")),
Reader.GetDateTime(Reader.GetOrdinal("IssueDate")),
Reader.GetBoolean(Reader.GetOrdinal("IsActive"))
                                 );

                            }
                            else
                                librarycardDTO = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                librarycardDTO = null;
            }
            return librarycardDTO;

        }

        public static bool UpdateStatusLibraryCard(int LibraryCardID, bool NewStatus)
        {
            int RowsEffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_UpdateStatusLibraryCard", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                       
                        Command.Parameters.AddWithValue("@NewStatus", NewStatus);
                        Command.Parameters.AddWithValue("@LibraryCardID", LibraryCardID);


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
    }
}
