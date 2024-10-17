using LibraryBook_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook_Buisness
{
    public class LibraryCard
    {


        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        public LibraryCardDTO librarycardDTO
        {
            get => new LibraryCardDTO(this.LibraryCardID, this.LibraryCardNumber, this.IssueDate, this.IsActive);
        }
        public int LibraryCardID { get; set; }
        public string LibraryCardNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public bool IsActive { get; set; }

        public LibraryCard(LibraryCardDTO librarycardDTO, enMode CreationMode = enMode.AddNew)
        {
            this.LibraryCardID = librarycardDTO.LibraryCardID;
            this.LibraryCardNumber = librarycardDTO.LibraryCardNumber;
            this.IssueDate = librarycardDTO.IssueDate;
            this.IsActive = librarycardDTO.IsActive
            ;
            Mode = CreationMode;
        }

        public static LibraryCard Find(int LibraryCardID)
        {

            LibraryCardDTO librarycardDTO = LibraryCardData.GetLibraryCardInfoByID(LibraryCardID);

            if (librarycardDTO != null)
            {
                return new LibraryCard(librarycardDTO, enMode.Update);
            }
            return null;

        }

        private bool _AddNewLibraryCard()
        {
            this.LibraryCardID = LibraryCardData.AddNewLibraryCard(this.librarycardDTO);
            return (this.LibraryCardID != -1);
        }

        private bool _UpdateLibraryCard()
        {
            return LibraryCardData.UpdateLibraryCard(this.librarycardDTO);
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
            return LibraryCardData.DeleteLibraryCard(LibraryCardID);
        }

        public static List<LibraryCardDTO> GetAllLibraryCards()
        {
            return LibraryCardData.GetAllLibraryCards();
        }

        public static bool IsLibraryCardExistByID(int LibraryCardID)
        {
            return LibraryCardData.IsLibraryCardExistByID(LibraryCardID);
        }

        public bool UpdateStatus(bool NewStatus)
        {
            return LibraryCardData.UpdateStatusLibraryCard(this.LibraryCardID,NewStatus) ;
        }
    }
}
