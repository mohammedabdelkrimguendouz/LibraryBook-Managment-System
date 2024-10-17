
using LibraryBook_Buisness;
using LibraryBook_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook_Buisness
{
    public class Person
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        public PersonDTO personDTO
        {
            get => new PersonDTO(this.PersonID, this.NationalNo, this.FirstName, this.MidlleName, this.LastName, this.Gender, this.DateOfBirth, this.Phone, this.Email, this.Address, this.LibraryCardID, this.ImagePath);
        }
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
        public LibraryCard LibraryCardInfo;
        public string ImagePath { get; set; }

        public Person(PersonDTO personDTO, enMode CreationMode = enMode.AddNew)
        {
            this.PersonID = personDTO.PersonID;
            this.NationalNo = personDTO.NationalNo;
            this.FirstName = personDTO.FirstName;
            this.MidlleName = personDTO.MidlleName;
            this.LastName = personDTO.LastName;
            this.Gender = personDTO.Gender;
            this.DateOfBirth = personDTO.DateOfBirth;
            this.Phone = personDTO.Phone;
            this.Email = personDTO.Email;
            this.Address = personDTO.Address;
            this.LibraryCardID = personDTO.LibraryCardID;
            this.LibraryCardInfo=LibraryCard.Find(personDTO.LibraryCardID);
            this.ImagePath = personDTO.ImagePath
            ;
            Mode = CreationMode;
        }

        public static Person Find(int PersonID)
        {

            PersonDTO personDTO = PersonData.GetPersonInfoByID(PersonID);

            if (personDTO != null)
            {
                return new Person(personDTO, enMode.Update);
            }
            return null;

        }
        public static Person Find(string LibraryCardNumber)
        {

            PersonDTO personDTO = PersonData.GetPersonInfoByLibraryCardNumber(LibraryCardNumber);

            if (personDTO != null)
            {
                return new Person(personDTO, enMode.Update);
            }
            return null;

        }

        private bool _AddNewPerson()
        {
            this.PersonID = PersonData.AddNewPerson(this.personDTO);
            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return PersonData.UpdatePerson(this.personDTO);
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

        public static bool DeletePerson(int PersonID)
        {
            return PersonData.DeletePerson(PersonID);
        }

        public static List<PeopleListDTO> GetAllPeople()
        {
            return PersonData.GetAllPeople();
        }

        public static bool IsPersonExist(int PersonID)
        {
            return PersonData.IsPersonExistByID(PersonID);
        }

       

        
        static public bool IsPersonExist(string NationalNo)
        {
            return PersonData.IsPersonExistByNationalNo(NationalNo);
        }
        public bool UpdateStatus(bool NewStatus)
        {
            return LibraryCardData.UpdateStatusLibraryCard(this.LibraryCardID, NewStatus);
        }
    }
}
