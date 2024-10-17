﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace LibraryBook_DataAccess
{

    public class CountryDTO
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public CountryDTO(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

    }
    public class CountryData
    {
        public static List<CountryDTO> GetAllCountries()
        {
            List<CountryDTO> ListCountries = new List<CountryDTO>();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetAllCountries", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                ListCountries.Add
                                   (
                                      new CountryDTO
                                      (
                                         Reader.GetInt32(Reader.GetOrdinal("CountryID")),
Reader.GetString(Reader.GetOrdinal("CountryName"))
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

            return ListCountries;
        }

        

        public static CountryDTO GetCountryInfoByID(int CountryID)
        {
            CountryDTO countryDTO = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetCountryInfoByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@CountryID", CountryID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {

                                countryDTO = new CountryDTO(Reader.GetInt32(Reader.GetOrdinal("CountryID")),
Reader.GetString(Reader.GetOrdinal("CountryName"))
                                 );

                            }
                            else
                                countryDTO = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                countryDTO = null;
            }
            return countryDTO;

        }

        public static CountryDTO GetCountryInfoByName(string CountryName)
        {
            CountryDTO countryDTO = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetCountryInfoByName", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@CountryName", CountryName);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {

                                countryDTO = new CountryDTO(Reader.GetInt32(Reader.GetOrdinal("CountryID")),
Reader.GetString(Reader.GetOrdinal("CountryName"))
                                 );

                            }
                            else
                                countryDTO = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                 countryDTO = null;
            }
            return  countryDTO;
        }
       
    }
}
