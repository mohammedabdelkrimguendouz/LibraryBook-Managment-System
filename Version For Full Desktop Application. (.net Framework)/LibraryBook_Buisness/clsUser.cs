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
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        public int UserID { get; set; }

        public int PersonID {  get; set; }
        public clsPerson PersonInfo;
        public string UserName { get; set; }
        public string Password { get; set; }
       


        private clsUser(int UserID, int PersonID, string UserName, string Password)
           
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.PersonID = PersonID;
           
            this.PersonInfo = clsPerson.Find(PersonID);
            Mode = enMode.Update;
        }

        public clsUser()
        {
            UserID = -1;
            PersonID = -1;
            UserName = "";
            Password = "";
            
            Mode = enMode.AddNew;
        }

        public static clsUser Find(int UserID)
        {

             int PersonID = -1; string UserName = ""; string Password = "";


            bool IsFound = clsUserData.GetUserInfoByID
                (UserID, ref PersonID, ref UserName, ref Password);


            if (IsFound)
            {
                    return new clsUser( UserID, PersonID, UserName,  Password);

            }


            return null;

            

        }

        public static clsUser Find(string UserName,string Password)
        {

            int PersonID = -1, UserID = -1;


            bool IsFound = clsUserData.GetUserInfoByUserNameAndPassword
                (UserName, Password, ref UserID, ref PersonID );


            if (IsFound)
            {
                return new clsUser(UserID, PersonID, UserName, Password);

            }


            return null;



        }

        private bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewUser(PersonID, UserName, Password);

            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(UserID, PersonID, UserName, Password);

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
            return clsUserData.DeleteUser(UserID);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static bool IsUserExist(int UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }
        static public bool IsUserExist(string UserName)
        {
            return clsUserData.IsUserExistByUserName(UserName);
        }
        static public bool IsUserExistForPersonID(int PersonID)
        {
            return clsUserData.IsUserExistForPersonID(PersonID);
        }
    }
}
