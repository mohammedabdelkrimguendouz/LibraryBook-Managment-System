using DVLD_DataAccess;
using LibraryBook_Buisness;
using LibraryBook_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class clsPerson
    {
        private enum enMode { AddNew = 0,Update = 1  };
        private enMode Mode = enMode.AddNew;

        public enum enGender { Male = 0, Female = 1 };
        
        public int PersonID { set; get; }
        public string NationalNo { set; get; }

        public enGender Gender { set; get; }
        public string FirstName { set; get; }
        public string MidlleName { set; get; }

        public string LastName { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        public DateTime DateOfBirth { set; get; }

        public int LibraryCardID { set; get; }
        public clsLibraryCard LibraryCardInfo; 

        public string ImagePath {  set; get; }

        public string FullName
        {
            get { return FirstName + " " + MidlleName + " " + LastName; }
        }
        public clsPerson()
        {
            PersonID = -1;
            LibraryCardID = -1;
            NationalNo = "";
            FirstName = "";
            MidlleName = "";
            LastName = "";
            Email = "";
            Phone = "";
            Address = "";
            ImagePath = "";
            Gender = enGender.Male;
            DateOfBirth = DateTime.Now.AddYears(-9);
            Mode = enMode.AddNew;
        }

        private clsPerson(int PersonID, string NationalNo, string FirstName, string MidlleName, string LastName,
            string Email, string Phone, string Address, enGender Gender, DateTime DateOfBirth,
            int LibraryCardID, string ImagePath)

        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.MidlleName = MidlleName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.LibraryCardID = LibraryCardID;
            this.LibraryCardInfo = clsLibraryCard.Find(LibraryCardID);
            this.ImagePath = ImagePath;
            Mode = enMode.Update;
        }



        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonData.AddNewPerson(this.NationalNo, this.FirstName, this.MidlleName, this.LastName, this.Email, this.Phone,
                this.Address,(short) this.Gender, this.DateOfBirth, this.LibraryCardID, this.ImagePath);
            return (this.PersonID != -1);
        }

        public static clsPerson Find(int PersonID)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            string NationalNo = "", MidlleName = ""; short Gender = 0;int LibraryCardID = -1;
            DateTime DateOfBirth = DateTime.Now.AddYears(-9);
           

            if (clsPersonData.GetPersonInfoByID(PersonID, ref NationalNo, ref FirstName, ref MidlleName, ref LastName, ref Email, ref Phone,
             ref Address, ref Gender, ref DateOfBirth, ref LibraryCardID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, MidlleName, LastName, Email, Phone,
                Address, (enGender)Gender, DateOfBirth, LibraryCardID, ImagePath);

            }
            return null;

        }

        public static clsPerson Find(string LibraryCardNumber)
        {
            
            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "", NationalNo="";
            int PersonID = -1; string MidlleName = ""; short Gender = 0;int LibraryCardID = -1;
            DateTime DateOfBirth = DateTime.Now.AddYears(-9);
           

            if (clsPersonData.GetPersonInfoByLibraryCardNumber(LibraryCardNumber,ref NationalNo,ref PersonID, ref FirstName, ref MidlleName, ref LastName, ref Email, ref Phone,
             ref Address, ref Gender, ref DateOfBirth,ref LibraryCardID,ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, MidlleName, LastName, Email, Phone,
               Address,(enGender) Gender, DateOfBirth,LibraryCardID,ImagePath);

            }
            return null;

        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.PersonID,this.NationalNo, this.FirstName, this.MidlleName, this.LastName, this.Email, this.Phone,
                this.Address,(short) this.Gender, this.DateOfBirth, this.LibraryCardID, this.ImagePath);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdatePerson();
            }
            return false;
        }

        public static   bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

        static public bool ISPersonExist(int PersonID)
        {
            return clsPersonData.IsPersonExistByID(PersonID);
        }
        static public bool IsPersonExist(string NationalNo)
        {
            return clsPersonData.IsPersonExistByNationalNo(NationalNo);
        }
        public bool UpdateStatus(bool NewStatus)
        {
            return clsLibraryCardData.UpdateStatusLibraryCard(this.LibraryCardID, NewStatus);
        }
    }
}
