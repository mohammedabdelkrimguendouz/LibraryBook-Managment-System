using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook_DataAccess
{
    public class clsSettingData
    {
        public static byte GetDefualtBorrrowDays()
        {
            byte DefualtBorrrowDays = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetDefualtBorrrowDays", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;


                        SqlParameter outputParam = new SqlParameter("@DefualtBorrrowDays", SqlDbType.TinyInt)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputParam);


                        Command.ExecuteNonQuery();

                        DefualtBorrrowDays = (byte)outputParam.Value;

                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", System.Diagnostics.EventLogEntryType.Error);
                DefualtBorrrowDays = 0;
            }
            return DefualtBorrrowDays;
        }
        public static bool SetDefualtBorrrowDays( byte DefualtBorrrowDays)
        {
            int RowsEffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_SetDefualtBorrrowDays", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@DefualtBorrrowDays", DefualtBorrrowDays);

                        
                        RowsEffected = Command.ExecuteNonQuery();

                        

                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", System.Diagnostics.EventLogEntryType.Error);
                RowsEffected = 0;
            }
            return RowsEffected>0;
        }

        public static float GetDefaultFinePerDay()
        {
            float DefaultFinePerDay = 0.0f;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetDefaultFinePerDay", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;


                        SqlParameter outputParam = new SqlParameter("@DefaultFinePerDay", SqlDbType.SmallMoney)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputParam);


                        Command.ExecuteNonQuery();

                        DefaultFinePerDay = Convert.ToSingle(outputParam.Value);

                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", System.Diagnostics.EventLogEntryType.Error);
                DefaultFinePerDay = 0.0f;
            }
            return DefaultFinePerDay;
        }
        public static bool SetDefaultFinePerDay(float DefaultFinePerDay)
        {
            int RowsEffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_SetDefaultFinePerDay", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@DefaultFinePerDay", DefaultFinePerDay);


                        RowsEffected = Command.ExecuteNonQuery();



                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", System.Diagnostics.EventLogEntryType.Error);
                RowsEffected = 0;
            }
            return RowsEffected > 0;
        }

        public static float GetDefaultMonthlySubscriptionAmount()
        {
            float DefaultMonthlySubscriptionAmount = 0.0f;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetDefaultMonthlySubscriptionAmount", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;


                        SqlParameter outputParam = new SqlParameter("@DefaultMonthlySubscriptionAmount", SqlDbType.SmallMoney)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputParam);


                        Command.ExecuteNonQuery();

                        DefaultMonthlySubscriptionAmount = Convert.ToSingle(outputParam.Value);

                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", System.Diagnostics.EventLogEntryType.Error);
                DefaultMonthlySubscriptionAmount = 0.0f;
            }
            return DefaultMonthlySubscriptionAmount;
        }
        public static bool SetDefaultMonthlySubscriptionAmount(float DefaultMonthlySubscriptionAmount)
        {
            int RowsEffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_SetDefaultMonthlySubscriptionAmount", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@DefaultMonthlySubscriptionAmount", DefaultMonthlySubscriptionAmount);


                        RowsEffected = Command.ExecuteNonQuery();



                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", System.Diagnostics.EventLogEntryType.Error);
                RowsEffected = 0;
            }
            return RowsEffected > 0;
        }

        public static float GetDefaultAnnualSubscriptionAmount()
        {
            float DefaultAnnualSubscriptionAmount = 0.0f;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetDefaultAnnualSubscriptionAmount", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;


                        SqlParameter outputParam = new SqlParameter("@DefaultAnnualSubscriptionAmount", SqlDbType.SmallMoney)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputParam);


                        Command.ExecuteNonQuery();

                        DefaultAnnualSubscriptionAmount = Convert.ToSingle(outputParam.Value);

                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", System.Diagnostics.EventLogEntryType.Error);
                DefaultAnnualSubscriptionAmount = 0.0f;
            }
            return DefaultAnnualSubscriptionAmount;
        }
        public static bool SetDefaultAnnualSubscriptionAmount(float DefaultAnnualSubscriptionAmount)
        {
            int RowsEffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_SetDefaultAnnualSubscriptionAmount", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@DefaultAnnualSubscriptionAmount", DefaultAnnualSubscriptionAmount);


                        RowsEffected = Command.ExecuteNonQuery();



                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", System.Diagnostics.EventLogEntryType.Error);
                RowsEffected = 0;
            }
            return RowsEffected > 0;
        }

        public static byte GetDefaultNumberOfBorrowedBooks()
        {
            byte DefaultNumberOfBorrowedBooks = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetDefaultNumberOfBorrowedBooks", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;


                        SqlParameter outputParam = new SqlParameter("@DefaultNumberOfBorrowedBooks", SqlDbType.TinyInt)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputParam);


                        Command.ExecuteNonQuery();

                        DefaultNumberOfBorrowedBooks = (byte)outputParam.Value;

                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", System.Diagnostics.EventLogEntryType.Error);
                DefaultNumberOfBorrowedBooks = 0;
            }
            return DefaultNumberOfBorrowedBooks;
        }
        public static bool SetDefaultNumberOfBorrowedBooks(byte DefaultNumberOfBorrowedBooks)
        {
            int RowsEffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_SetDefaultNumberOfBorrowedBooks", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@DefaultNumberOfBorrowedBooks", DefaultNumberOfBorrowedBooks);


                        RowsEffected = Command.ExecuteNonQuery();



                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", System.Diagnostics.EventLogEntryType.Error);
                RowsEffected = 0;
            }
            return RowsEffected > 0;
        }

        public static byte GetDefaultNumberOfDaysWaitingForABookReserved()
        {
            byte DefaultNumberOfDaysWaitingForABookReserved = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetDefaultNumberOfDaysWaitingForABookReserved", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;


                        SqlParameter outputParam = new SqlParameter("@DefaultNumberOfDaysWaitingForABookReserved", SqlDbType.TinyInt)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputParam);


                        Command.ExecuteNonQuery();

                        DefaultNumberOfDaysWaitingForABookReserved = (byte)outputParam.Value;

                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", System.Diagnostics.EventLogEntryType.Error);
                DefaultNumberOfDaysWaitingForABookReserved = 0;
            }
            return DefaultNumberOfDaysWaitingForABookReserved;
        }
        public static bool SetDefaultNumberOfDaysWaitingForABookReserved(byte DefaultNumberOfDaysWaitingForABookReserved)
        {
            int RowsEffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_SetDefaultNumberOfDaysWaitingForABookReserved", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@DefaultNumberOfDaysWaitingForABookReserved", DefaultNumberOfDaysWaitingForABookReserved);


                        RowsEffected = Command.ExecuteNonQuery();



                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", System.Diagnostics.EventLogEntryType.Error);
                RowsEffected = 0;
            }
            return RowsEffected > 0;
        }

        public static bool GetIsShowConfigurationSettings()
        {
            bool IsShowConfigurationSettings = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetIsShowConfigurationSettings", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;


                        SqlParameter outputParam = new SqlParameter("@IsShowConfigurationSettings", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputParam);


                        Command.ExecuteNonQuery();

                        IsShowConfigurationSettings = ((bool)outputParam.Value);

                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", System.Diagnostics.EventLogEntryType.Error);
                IsShowConfigurationSettings = false;
            }
            return IsShowConfigurationSettings;
        }
        public static bool SetIsShowConfigurationSettings(bool IsShowConfigurationSettings)
        {
            int RowsEffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_SetIsShowConfigurationSettings", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@IsShowConfigurationSettings", IsShowConfigurationSettings);


                        RowsEffected = Command.ExecuteNonQuery();



                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", System.Diagnostics.EventLogEntryType.Error);
                RowsEffected = 0;
            }
            return RowsEffected > 0;
        }


        public static byte GetDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod()
        {
            byte DefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;


                        SqlParameter outputParam = new SqlParameter("@DefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod", SqlDbType.TinyInt)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputParam);


                        Command.ExecuteNonQuery();

                        DefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod = (byte)outputParam.Value;

                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", System.Diagnostics.EventLogEntryType.Error);
                DefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod = 0;
            }
            return DefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod;
        }
        public static bool SetDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod(byte DefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod)
        {
            int RowsEffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_SetDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@DefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod", DefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod);


                        RowsEffected = Command.ExecuteNonQuery();



                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", System.Diagnostics.EventLogEntryType.Error);
                RowsEffected = 0;
            }
            return RowsEffected > 0;
        }

    }
}
