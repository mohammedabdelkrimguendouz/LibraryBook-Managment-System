using LibraryBook_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook_Buisness
{
    public class clsLibraryCard
    {

       
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        public int LibraryCardID { get; set; }
        public string LibraryCardNumber { get; set; }
       
        public DateTime IssueDate { get; set; }
        public bool IsActive { get; set; }

        private clsLibraryCard(int LibraryCardID, string LibraryCardNumber, DateTime IssueDate, bool IsActive)
        {
            this.LibraryCardID = LibraryCardID;
            this.LibraryCardNumber = LibraryCardNumber;
            this.IssueDate = IssueDate;
            this.IsActive = IsActive;
            Mode = enMode.Update;
        }

        public clsLibraryCard()
        {
            LibraryCardID = -1;
            LibraryCardNumber = "";
            IssueDate = DateTime.Now;
            IsActive = false;
            Mode = enMode.AddNew;
        }

        public static clsLibraryCard Find(int LibraryCardID)
        {

             string LibraryCardNumber = ""; DateTime IssueDate = DateTime.Now; bool IsActive = false;

            if (clsLibraryCardData.GetLibraryCardInfoByID(LibraryCardID, ref LibraryCardNumber, ref IssueDate, ref IsActive))
            {
                return new clsLibraryCard(LibraryCardID, LibraryCardNumber, IssueDate, IsActive);

            }
            return null;

        }

        private bool _AddNewLibraryCard()
        {
            this.LibraryCardID = clsLibraryCardData.AddNewLibraryCard(LibraryCardNumber, IssueDate, IsActive);


           return (this.LibraryCardID != -1);

        }

        private bool _UpdateLibraryCard()
        {
            return clsLibraryCardData.UpdateLibraryCard(LibraryCardID, LibraryCardNumber, IssueDate, IsActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLibraryCard())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateLibraryCard();
            }
            return false;
        }

        public static bool DeleteLibraryCard(int LibraryCardID)
        {
            return clsLibraryCardData.DeleteLibraryCard(LibraryCardID);
        }

        public static DataTable GetAllLibraryCards()
        {
            return clsLibraryCardData.GetAllLibraryCards();
        }

        public static bool IsLibraryCardExist(int LibraryCardID)
        {
            return clsLibraryCardData.IsLibraryCardExist(LibraryCardID);
        }

        public bool UpdateStatus(bool NewStatus)
        {
            return clsLibraryCardData.UpdateStatusLibraryCard(this.LibraryCardID,NewStatus) ;
        }
    }
}
