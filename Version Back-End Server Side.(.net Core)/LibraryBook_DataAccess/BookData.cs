
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
    public class BookDTO
    {
        public int BookID { get; set; }
        public int GenreID { get; set; }
        public string Title { get; set; }
        public int PagesNumber { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
        public string? CoverImage { get; set; }
        public string? AdditionalDetails { get; set; }
        public decimal? Price { get; set; }

        public BookDTO(int BookID, int GenreID, string Title, int PagesNumber, string ISBN, DateTime PublicationDate, string? CoverImage, string? AdditionalDetails, decimal? Price)
        {
            this.BookID = BookID;
            this.GenreID = GenreID;
            this.Title = Title;
            this.PagesNumber = PagesNumber;
            this.ISBN = ISBN;
            this.PublicationDate = PublicationDate;
            this.CoverImage = CoverImage;
            this.AdditionalDetails = AdditionalDetails;
            this.Price = Price;
        }

    }

    public class BooksListDTO
    {
        public int BookID { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string GenreName { get; set; }
        public int NumberOfAuthors {  get; set; }

        public int NumberOfCopies { get; set; }

        public BooksListDTO(int bookID, string iSBN, string title, string genreName, int numberOfAuthors, int numberOfCopies)
        {
            BookID = bookID;
            ISBN = iSBN;
            Title = title;
            GenreName = genreName;
            NumberOfAuthors = numberOfAuthors;
            NumberOfCopies = numberOfCopies;
        }
    }
    public class BookData
    {

        public static int AddNewBook(BookDTO bookDTO)
        {
            int BookID = -1;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_AddNewBook", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@GenreID", bookDTO.GenreID);
                        Command.Parameters.AddWithValue("@Title", bookDTO.Title);
                        Command.Parameters.AddWithValue("@PagesNumber", bookDTO.PagesNumber);
                        Command.Parameters.AddWithValue("@ISBN", bookDTO.ISBN);
                        Command.Parameters.AddWithValue("@PublicationDate", bookDTO.PublicationDate);
                        if (bookDTO.CoverImage != null && bookDTO.CoverImage != "")
                            Command.Parameters.AddWithValue("@CoverImage", bookDTO.CoverImage);
                        else
                            Command.Parameters.AddWithValue("@CoverImage", DBNull.Value);
                        if (bookDTO.AdditionalDetails != null && bookDTO.AdditionalDetails != "")
                            Command.Parameters.AddWithValue("@AdditionalDetails", bookDTO.AdditionalDetails);
                        else
                            Command.Parameters.AddWithValue("@AdditionalDetails", DBNull.Value);
                        if (bookDTO.Price != null)
                            Command.Parameters.AddWithValue("@Price", bookDTO.Price);
                        else
                            Command.Parameters.AddWithValue("@Price", DBNull.Value);


                        SqlParameter outputIdParam = new SqlParameter("BookID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIdParam);


                        Command.ExecuteNonQuery();

                        BookID = (int)outputIdParam.Value;

                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                BookID = -1;
            }
            return BookID;
        }

        public static bool UpdateBook(BookDTO bookDTO)
        {
            int RowsEffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_UpdateBook", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@BookID", bookDTO.BookID);
                        Command.Parameters.AddWithValue("@GenreID", bookDTO.GenreID);
                        Command.Parameters.AddWithValue("@Title", bookDTO.Title);
                        Command.Parameters.AddWithValue("@PagesNumber", bookDTO.PagesNumber);
                        Command.Parameters.AddWithValue("@ISBN", bookDTO.ISBN);
                        Command.Parameters.AddWithValue("@PublicationDate", bookDTO.PublicationDate);
                        if (bookDTO.CoverImage != null && bookDTO.CoverImage != "")
                            Command.Parameters.AddWithValue("@CoverImage", bookDTO.CoverImage);
                        else
                            Command.Parameters.AddWithValue("@CoverImage", DBNull.Value);
                        if (bookDTO.AdditionalDetails != null && bookDTO.AdditionalDetails != "")
                            Command.Parameters.AddWithValue("@AdditionalDetails", bookDTO.AdditionalDetails);
                        else
                            Command.Parameters.AddWithValue("@AdditionalDetails", DBNull.Value);
                        if (bookDTO.Price != null)
                            Command.Parameters.AddWithValue("@Price", bookDTO.Price);
                        else
                            Command.Parameters.AddWithValue("@Price", DBNull.Value);


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

        public static bool DeleteBook(int BookID)
        {
            int RowsEffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_DeleteBook", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@BookID", BookID);


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

        public static List<BooksListDTO> GetAllBooks()
        {
            List<BooksListDTO> ListBooks = new List<BooksListDTO>();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetAllBooks", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                ListBooks.Add
                                   (
                                      new BooksListDTO
                                      (
                                         Reader.GetInt32(Reader.GetOrdinal("BookID")),
                                         Reader.GetString(Reader.GetOrdinal("ISBN")),
Reader.GetString(Reader.GetOrdinal("Title")),
Reader.GetString(Reader.GetOrdinal("GenreName")),

Reader.GetInt32(Reader.GetOrdinal("NumberOfAuthors")),
Reader.GetInt32(Reader.GetOrdinal("NumberOfCopies"))
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

            return ListBooks;
        }

        public static bool IsBookExistByID(int BookID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_IsBookExistByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@BookID", BookID);
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

        public static BookDTO GetBookInfoByID(int BookID)
        {
            BookDTO bookDTO = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetBookInfoByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@BookID", BookID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {

                                bookDTO = new BookDTO(Reader.GetInt32(Reader.GetOrdinal("BookID")),
Reader.GetInt32(Reader.GetOrdinal("GenreID")),
Reader.GetString(Reader.GetOrdinal("Title")),
Reader.GetInt32(Reader.GetOrdinal("PagesNumber")),
Reader.GetString(Reader.GetOrdinal("ISBN")),
Reader.GetDateTime(Reader.GetOrdinal("PublicationDate")),
Reader.IsDBNull(Reader.GetOrdinal("CoverImage")) ? null : Reader.GetString(Reader.GetOrdinal("CoverImage")),
Reader.IsDBNull(Reader.GetOrdinal("AdditionalDetails")) ? null : Reader.GetString(Reader.GetOrdinal("AdditionalDetails")),
Reader.IsDBNull(Reader.GetOrdinal("Price")) ? null : Reader.GetDecimal(Reader.GetOrdinal("Price"))
                                 );

                            }
                            else
                                bookDTO = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                bookDTO = null;
            }
            return bookDTO;

        }



        public static bool IsBookExist(string ISBN)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_IsBookExistByISBN", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ISBN", ISBN);
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

        

        public static BookDTO GetBookInfoByISBN( string ISBN)
        {
            BookDTO bookDTO = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetBookInfoByISBN", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ISBN", ISBN);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {

                                bookDTO = new BookDTO(Reader.GetInt32(Reader.GetOrdinal("BookID")),
Reader.GetInt32(Reader.GetOrdinal("GenreID")),
Reader.GetString(Reader.GetOrdinal("Title")),
Reader.GetInt32(Reader.GetOrdinal("PagesNumber")),
Reader.GetString(Reader.GetOrdinal("ISBN")),
Reader.GetDateTime(Reader.GetOrdinal("PublicationDate")),
Reader.IsDBNull(Reader.GetOrdinal("CoverImage")) ? null : Reader.GetString(Reader.GetOrdinal("CoverImage")),
Reader.IsDBNull(Reader.GetOrdinal("AdditionalDetails")) ? null : Reader.GetString(Reader.GetOrdinal("AdditionalDetails")),
Reader.IsDBNull(Reader.GetOrdinal("Price")) ? null : Reader.GetDecimal(Reader.GetOrdinal("Price"))
                                 );

                            }
                            else
                                bookDTO = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                bookDTO = null;
            }
            return bookDTO;

        }

        public static int GetNumberOfAuthorsForBook(int BookID)
        {
            int NumberOfAuthors = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetNumberOfAuthorsForBook", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@BookID", BookID);



                        SqlParameter NumberParam = new SqlParameter("@Number", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(NumberParam);

                        Command.ExecuteNonQuery();

                        NumberOfAuthors = (int)NumberParam.Value;

                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                NumberOfAuthors = 0;
            }
            return NumberOfAuthors;
        }

        public static int GetNumberOfCopiesForBook(int BookID)
        {
            int NumberOfCopies = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetNumberOfCopiesForBook", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@BookID", BookID);



                        SqlParameter NumberParam = new SqlParameter("@Number", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(NumberParam);

                        Command.ExecuteNonQuery();

                        NumberOfCopies = (int)NumberParam.Value;

                    }
                }

            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                NumberOfCopies = 0;
            }
            return NumberOfCopies;
        }


    }
}
