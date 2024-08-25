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
    public class clsReservation
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enum enReservationStatus { Active =1, Cancelled = 2, Completed =3};
        private enMode Mode = enMode.AddNew;
        public int ReservationID { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo;
        public int BookCopyID { get; set; }
        public clsBookCopy BookCopyInfo;
        public DateTime ReservationDate { get; set; }
        public enReservationStatus ReservationStatus { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo;

        private clsReservation(int ReservationID, int PersonID, int BookCopyID, DateTime ReservationDate, enReservationStatus ReservationStatus, int CreatedByUserID)
        {
            this.ReservationID = ReservationID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(PersonID);
            this.BookCopyID = BookCopyID;
            this.BookCopyInfo=clsBookCopy.Find(BookCopyID);
            this.ReservationDate = ReservationDate;
            this.ReservationStatus = ReservationStatus;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo=clsUser.Find(CreatedByUserID);
            Mode = enMode.Update;
        }

        public clsReservation()
        {
            ReservationID = -1;
            PersonID = -1;
            BookCopyID = -1;
            ReservationDate = DateTime.Now;
            ReservationStatus = enReservationStatus.Active;
            CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }

        public static clsReservation Find(int ReservationID)
        {

            int PersonID = -1; int BookCopyID = -1; DateTime ReservationDate = DateTime.Now; byte ReservationStatus = 1; int CreatedByUserID = -1;
        
            if (clsReservationData.GetReservationInfoByID( ReservationID, ref PersonID, ref BookCopyID, ref ReservationDate, ref ReservationStatus, ref CreatedByUserID))
            {
                return new clsReservation(ReservationID, PersonID, BookCopyID, ReservationDate,(enReservationStatus) ReservationStatus, CreatedByUserID);

            }
            return null;

        }

        private bool _AddNewReservation()
        {
            this.ReservationID = clsReservationData.AddNewReservation(PersonID, BookCopyID, ReservationDate,(byte) ReservationStatus, CreatedByUserID);

            return (this.ReservationID != -1);
        }

        private bool _UpdateReservation()
        {
            return clsReservationData.UpdateReservation(ReservationID, PersonID, BookCopyID, ReservationDate,(byte) ReservationStatus, CreatedByUserID);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewReservation())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateReservation();
            }
            return false;
        }

        public static bool DeleteReservation(int ReservationID)
        {
            return clsReservationData.DeleteReservation(ReservationID);
        }

        public static DataTable GetAllReservations()
        {
            return clsReservationData.GetAllReservations();
        }

        public static bool IsReservationExist(int ReservationID)
        {
            return clsReservationData.IsReservationExist(ReservationID);
        }
        public static int GetReservationIDIfBookCopyReserved(int BookCopyID)
        {
            return clsReservationData.GetReservationIDIfBookCopyReserved(BookCopyID);
        }

        public static bool CheckReservationStatus()
        {
            return clsReservationData.CheckReservationStatus();
        }


    }
}
