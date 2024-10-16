using DVLD_Buisness;
using LibraryBook_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook_Buisness
{
    public class clsBorrowingRecord
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        public int BorrowingRecordID { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo;
        public int BookCopyID { get; set; }
        public clsBookCopy BookCopyInfo;
        public DateTime BorrowingDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }
        
        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo;

        private clsBorrowingRecord(int BorrowingRecordID, int PersonID, int BookCopyID, DateTime BorrowingDate, DateTime DueDate, DateTime? ActualReturnDate, int CreatedByUserID)
        {
            this.BorrowingRecordID = BorrowingRecordID;
            this.PersonID = PersonID;
            this.PersonInfo=clsPerson.Find(PersonID);
            this.BookCopyID = BookCopyID;
            this.BookCopyInfo = clsBookCopy.Find(BookCopyID);
            this.BorrowingDate = BorrowingDate;
            this.DueDate = DueDate;
            this.ActualReturnDate = ActualReturnDate;
            
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo=clsUser.Find(CreatedByUserID);
            Mode = enMode.Update;
        }

        public clsBorrowingRecord()
        {
            BorrowingRecordID = -1;
            PersonID = -1;
            BookCopyID = -1;
            BorrowingDate = DateTime.Now;
            DueDate = DateTime.Now;
            ActualReturnDate = null;
            
            CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }

        public static clsBorrowingRecord Find(int BorrowingRecordID)
        {

            int PersonID = -1; int BookCopyID = -1; DateTime BorrowingDate = DateTime.Now; DateTime DueDate = DateTime.Now; DateTime? ActualReturnDate = null;  int CreatedByUserID = -1;
        
            if (clsBorrowingRecordData.GetBorrowingRecordInfoByID( BorrowingRecordID, ref PersonID, ref BookCopyID, ref BorrowingDate, ref DueDate, ref ActualReturnDate, ref CreatedByUserID))
            {
                return new clsBorrowingRecord(BorrowingRecordID, PersonID, BookCopyID, BorrowingDate, DueDate, ActualReturnDate, CreatedByUserID);

            }
            return null;

        }

        private bool _AddNewBorrowingRecord()
        {
            this.BorrowingRecordID = clsBorrowingRecordData.AddNewBorrowingRecord(PersonID, BookCopyID, BorrowingDate, DueDate, ActualReturnDate, CreatedByUserID);

            return (this.BorrowingRecordID != -1);
        }

        private bool _UpdateBorrowingRecord()
        {
            return clsBorrowingRecordData.UpdateBorrowingRecord(BorrowingRecordID, PersonID, BookCopyID, BorrowingDate, DueDate, ActualReturnDate, CreatedByUserID);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBorrowingRecord())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateBorrowingRecord();
            }
            return false;
        }

        public static bool DeleteBorrowingRecord(int BorrowingRecordID)
        {
            return clsBorrowingRecordData.DeleteBorrowingRecord(BorrowingRecordID);
        }

        public static DataTable GetAllBorrowingRecords()
        {
            return clsBorrowingRecordData.GetAllBorrowingRecords();
        }

        public static DataTable GetAllBorrowingRecordsForPageNumber(int PageNumber)
        {
            return clsBorrowingRecordData.GetAllBorrowingRecordsForPageNumber(PageNumber);
        }

        public static bool IsBorrowingRecordExist(int BorrowingRecordID)
        {
            return clsBorrowingRecordData.IsBorrowingRecordExist(BorrowingRecordID);
        }

        public static byte GetNumberOfBorrowingBooksAndNotReturnForPerson(int PersonID)
        {
            return clsBorrowingRecordData.GetNumberOfBorrowingBooksAndNotReturnForPerson(PersonID);
        }
    }
}
