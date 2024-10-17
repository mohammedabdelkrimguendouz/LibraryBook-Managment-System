
using LibraryBook_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook_Buisness
{
    public class User
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        public UserDTO userDTO
        {
            get => new UserDTO(this.UserID, this.PersonID, this.UserName, this.Password);
        }
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public Person PersonInfo;
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(UserDTO userDTO, enMode CreationMode = enMode.AddNew)
        {
            this.UserID = userDTO.UserID;
            this.PersonID = userDTO.PersonID;
            this.PersonInfo= Person.Find(userDTO.PersonID);
            this.UserName = userDTO.UserName;
            this.Password = userDTO.Password
            ;
            Mode = CreationMode;
        }

        public static User Find(int UserID)
        {

            UserDTO userDTO = UserData.GetUserInfoByID(UserID);

            if (userDTO != null)
            {
                return new User(userDTO, enMode.Update);
            }
            return null;

        }

        public static User Find(string UserName, string Password)
        {

            UserDTO userDTO = UserData.GetUserInfoByUserNameAndPassword(UserName, Password);

            if (userDTO != null)
            {
                return new User(userDTO, enMode.Update);
            }
            return null;



        }

        private bool _AddNewUser()
        {
            this.UserID = UserData.AddNewUser(this.userDTO);
            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return UserData.UpdateUser(this.userDTO);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        public static bool DeleteUser(int UserID)
        {
            return UserData.DeleteUser(UserID);
        }

        public static List<UsersListDTO> GetAllUsers()
        {
            return UserData.GetAllUsers();
        }

        public static bool IsUserExist(int UserID)
        {
            return UserData.IsUserExistByID(UserID);
        }


       

        
        static public bool IsUserExist(string UserName)
        {
            return UserData.IsUserExistByUserName(UserName);
        }
        static public bool IsUserExistForPersonID(int PersonID)
        {
            return UserData.IsUserExistForPersonID(PersonID);
        }
    }
}
