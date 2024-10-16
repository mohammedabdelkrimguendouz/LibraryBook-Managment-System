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
    public class clsFine
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        public int FineID { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo;
        public int BorrowingRecordID { get; set; }
        public clsBorrowingRecord BorrowingRecordInfo;
        public int NumberOfLateDays { get; set; }
        public float FineAmount { get; set; }
        public int? PaymentID { get; set; }
        public clsPayment PaymentInfo;
        public bool Paid { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo;

        private clsFine(int FineID, int PersonID, int BorrowingRecordID, int NumberOfLateDays, float FineAmount, int? PaymentID, bool Paid, int CreatedByUserID)
        {
            this.FineID = FineID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(PersonID);
            this.BorrowingRecordID = BorrowingRecordID;
            this.BorrowingRecordInfo=clsBorrowingRecord.Find(BorrowingRecordID);
            this.NumberOfLateDays = NumberOfLateDays;
            this.FineAmount = FineAmount;
            this.PaymentID = PaymentID;
            this.PaymentInfo = (PaymentID == null) ? null : clsPayment.Find(PaymentID.Value);
            this.Paid = Paid;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.Find(CreatedByUserID);
            Mode = enMode.Update;
        }

        public clsFine()
        {
            FineID = -1;
            PersonID = -1;
            BorrowingRecordID = -1;
            NumberOfLateDays = -1;
            FineAmount = 0;
            PaymentID = null;
            Paid = false;
            CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }

        public static clsFine FindByID(int FineID)
        {

            int PersonID = -1; int BorrowingRecordID = -1; int NumberOfLateDays = -1; float FineAmount = 0; int? PaymentID = null; bool Paid = false; int CreatedByUserID = -1;
        
            if (clsFineData.GetFineInfoByID( FineID, ref PersonID, ref BorrowingRecordID, ref NumberOfLateDays, ref FineAmount, ref PaymentID, ref Paid, ref CreatedByUserID))
            {
                return new clsFine(FineID, PersonID, BorrowingRecordID, NumberOfLateDays, FineAmount, PaymentID, Paid, CreatedByUserID);

            }
            return null;

        }

        public static clsFine FindByBorrowingRecord(int BorrowingRecordID)
        {

            int PersonID = -1; int FineID = -1; int NumberOfLateDays = -1; float FineAmount = 0; int? PaymentID = null; bool Paid = false; int CreatedByUserID = -1;

            if (clsFineData.GetFineInfoByBorrowingRecord(BorrowingRecordID,ref FineID, ref PersonID, ref NumberOfLateDays, ref FineAmount, ref PaymentID, ref Paid, ref CreatedByUserID))
            {
                return new clsFine(FineID, PersonID, BorrowingRecordID, NumberOfLateDays, FineAmount, PaymentID, Paid, CreatedByUserID);

            }
            return null;

        }

        private bool _AddNewFine()
        {
            this.FineID = clsFineData.AddNewFine(PersonID, BorrowingRecordID, NumberOfLateDays, FineAmount, PaymentID, Paid, CreatedByUserID);

            return (this.FineID != -1);
        }

        private bool _UpdateFine()
        {
            return clsFineData.UpdateFine(FineID, PersonID, BorrowingRecordID, NumberOfLateDays, FineAmount, PaymentID, Paid, CreatedByUserID);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewFine())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateFine();
            }
            return false;
        }

        public static bool DeleteFine(int FineID)
        {
            return clsFineData.DeleteFine(FineID);
        }

        public static DataTable GetAllFines()
        {
            return clsFineData.GetAllFines();
        }

        public static bool IsFineExist(int FineID)
        {
            return clsFineData.IsFineExist(FineID);
        }
        public static bool IsPersonHaveFineNotPaid(int PersonID)
        {
             return clsFineData.IsPersonHaveFineNotPaid(PersonID);
        }

    }
}
