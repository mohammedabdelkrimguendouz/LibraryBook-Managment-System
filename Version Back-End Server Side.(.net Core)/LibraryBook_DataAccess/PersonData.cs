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
    public class PersonDTO
    {
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string? MidlleName { get; set; }
        public string LastName { get; set; }
        public byte Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public int LibraryCardID { get; set; }
        public string ImagePath { get; set; }

        public PersonDTO(int PersonID, string NationalNo, string FirstName, string? MidlleName, string LastName, byte Gender, DateTime DateOfBirth, string Phone, string? Email, string? Address, int LibraryCardID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.MidlleName = MidlleName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            this.LibraryCardID = LibraryCardID;
            this.ImagePath = ImagePath;
        }

    }

    public class PeopleListDTO
    {
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }

        public string LibraryCardNumber { get; set; }
        public bool IsActive { get; set; }

        public PeopleListDTO(int personID, string nationalNo, string fullName, string gender, string phone,string libraryCardNumber, bool isActive)
        {
            PersonID = personID;
            NationalNo = nationalNo;
            FullName = fullName;
            Gender = gender;
            Phone = phone;
            IsActive = isActive;
            LibraryCardNumber=libraryCardNumber;
        }
    }
    public class PersonData
    {
        public static int AddNewPerson(PersonDTO personDTO)
        {
            int PersonID = -1;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_AddNewPerson", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@NationalNo", personDTO.NationalNo);
                        Command.Parameters.AddWithValue("@FirstName", personDTO.FirstName);
                        if (personDTO.MidlleName != null && personDTO.MidlleName != "")
                            Command.Parameters.AddWithValue("@MidlleName", personDTO.MidlleName);
                        else
                            Command.Parameters.AddWithValue("@MidlleName", DBNull.Value);
                        Command.Parameters.AddWithValue("@LastName", personDTO.LastName);
                        Command.Parameters.AddWithValue("@Gender", personDTO.Gender);
                        Command.Parameters.AddWithValue("@DateOfBirth", personDTO.DateOfBirth);
                        Command.Parameters.AddWithValue("@Phone", personDTO.Phone);
                        if (personDTO.Email != null && personDTO.Email != "")
                            Command.Parameters.AddWithValue("@Email", personDTO.Email);
                        else
                            Command.Parameters.AddWithValue("@Email", DBNull.Value);
                        if (personDTO.Address != null && personDTO.Address != "")
                            Command.Parameters.AddWithValue("@Address", personDTO.Address);
                        else
                            Command.Parameters.AddWithValue("@Address", DBNull.Value);
                        Command.Parameters.AddWithValue("@LibraryCardID", personDTO.LibraryCardID);
                        Command.Parameters.AddWithValue("@ImagePath", personDTO.ImagePath);


                        SqlParameter outputIdParam = new SqlParameter("PersonID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIdParam);


                        Command.ExecuteNonQuery();

                        PersonID = (int)outputIdParam.Value;

                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                PersonID = -1;
            }
            return PersonID;
        }

        public static bool UpdatePerson(PersonDTO personDTO)
        {
            int RowsEffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_UpdatePerson", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PersonID", personDTO.PersonID);
                        Command.Parameters.AddWithValue("@NationalNo", personDTO.NationalNo);
                        Command.Parameters.AddWithValue("@FirstName", personDTO.FirstName);
                        if (personDTO.MidlleName != null && personDTO.MidlleName != "")
                            Command.Parameters.AddWithValue("@MidlleName", personDTO.MidlleName);
                        else
                            Command.Parameters.AddWithValue("@MidlleName", DBNull.Value);
                        Command.Parameters.AddWithValue("@LastName", personDTO.LastName);
                        Command.Parameters.AddWithValue("@Gender", personDTO.Gender);
                        Command.Parameters.AddWithValue("@DateOfBirth", personDTO.DateOfBirth);
                        Command.Parameters.AddWithValue("@Phone", personDTO.Phone);
                        if (personDTO.Email != null && personDTO.Email != "")
                            Command.Parameters.AddWithValue("@Email", personDTO.Email);
                        else
                            Command.Parameters.AddWithValue("@Email", DBNull.Value);
                        if (personDTO.Address != null && personDTO.Address != "")
                            Command.Parameters.AddWithValue("@Address", personDTO.Address);
                        else
                            Command.Parameters.AddWithValue("@Address", DBNull.Value);
                        Command.Parameters.AddWithValue("@LibraryCardID", personDTO.LibraryCardID);
                        Command.Parameters.AddWithValue("@ImagePath", personDTO.ImagePath);


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

        public static bool DeletePerson(int PersonID)
        {
            int RowsEffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_DeletePerson", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PersonID", PersonID);


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

        public static List<PeopleListDTO> GetAllPeople()
        {
            List<PeopleListDTO> ListPeople = new List<PeopleListDTO>();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetAllPeople", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                ListPeople.Add
                                   (
                                      new PeopleListDTO
                                      (
                                         Reader.GetInt32(Reader.GetOrdinal("PersonID")),
Reader.GetString(Reader.GetOrdinal("NationalNo")),
Reader.GetString(Reader.GetOrdinal("FullName")),
Reader.GetString(Reader.GetOrdinal("Gender")),
Reader.GetString(Reader.GetOrdinal("Phone")),
Reader.GetString(Reader.GetOrdinal("LibraryCardNumber")),
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

            return ListPeople;
        }

        public static bool IsPersonExistByID(int PersonID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_IsPersonExistByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PersonID", PersonID);
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

        public static PersonDTO GetPersonInfoByID(int PersonID)
        {
            PersonDTO personDTO = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetPersonInfoByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PersonID", PersonID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {

                                personDTO = new PersonDTO(Reader.GetInt32(Reader.GetOrdinal("PersonID")),
Reader.GetString(Reader.GetOrdinal("NationalNo")),
Reader.GetString(Reader.GetOrdinal("FirstName")),
Reader.IsDBNull(Reader.GetOrdinal("MidlleName")) ? null : Reader.GetString(Reader.GetOrdinal("MidlleName")),
Reader.GetString(Reader.GetOrdinal("LastName")),
Reader.GetByte(Reader.GetOrdinal("Gender")),
Reader.GetDateTime(Reader.GetOrdinal("DateOfBirth")),
Reader.GetString(Reader.GetOrdinal("Phone")),
Reader.IsDBNull(Reader.GetOrdinal("Email")) ? null : Reader.GetString(Reader.GetOrdinal("Email")),
Reader.IsDBNull(Reader.GetOrdinal("Address")) ? null : Reader.GetString(Reader.GetOrdinal("Address")),
Reader.GetInt32(Reader.GetOrdinal("LibraryCardID")),
Reader.GetString(Reader.GetOrdinal("ImagePath"))
                                 );

                            }
                            else
                                personDTO = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                personDTO = null;
            }
            return personDTO;

        }



        public static bool IsPersonExistByNationalNo(string NationalNo)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_IsPersonExistByNationalNo", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@NationalNo", NationalNo);

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

        public static PersonDTO GetPersonInfoByLibraryCardNumber(string LibraryCardNumber)
        {
            PersonDTO personDTO = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetPersonInfoByLibraryCardNumber", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@LibraryCardNumber", LibraryCardNumber);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                personDTO = new PersonDTO(Reader.GetInt32(Reader.GetOrdinal("PersonID")),
Reader.GetString(Reader.GetOrdinal("NationalNo")),
Reader.GetString(Reader.GetOrdinal("FirstName")),
Reader.IsDBNull(Reader.GetOrdinal("MidlleName")) ? null : Reader.GetString(Reader.GetOrdinal("MidlleName")),
Reader.GetString(Reader.GetOrdinal("LastName")),
Reader.GetByte(Reader.GetOrdinal("Gender")),
Reader.GetDateTime(Reader.GetOrdinal("DateOfBirth")),
Reader.GetString(Reader.GetOrdinal("Phone")),
Reader.IsDBNull(Reader.GetOrdinal("Email")) ? null : Reader.GetString(Reader.GetOrdinal("Email")),
Reader.IsDBNull(Reader.GetOrdinal("Address")) ? null : Reader.GetString(Reader.GetOrdinal("Address")),
Reader.GetInt32(Reader.GetOrdinal("LibraryCardID")),
Reader.GetString(Reader.GetOrdinal("ImagePath"))
                                );
                            }
                            else
                                personDTO=null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                personDTO = null;
            }
            return personDTO;
        }

    }
}
