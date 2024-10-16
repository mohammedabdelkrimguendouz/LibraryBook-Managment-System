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
    public class clsSubscriptionPeriod
    {
        public enum enSubscriptionPeriodStatus { Active=1,Cancelled=2,Completed=3}
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        public int SubscriptionPeriodID { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo;
        public int PaymentID { get; set; }
        public clsPayment PaymentInfo;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public enSubscriptionPeriodStatus Status { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo;

        private clsSubscriptionPeriod(int SubscriptionPeriodID, int PersonID, int PaymentID, DateTime StartDate, DateTime EndDate, enSubscriptionPeriodStatus Status, int CreatedByUserID)
        {
            this.SubscriptionPeriodID = SubscriptionPeriodID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(PersonID);
            this.PaymentID = PaymentID;
            this.PaymentInfo = clsPayment.Find(PaymentID);
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Status = Status;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.Find(CreatedByUserID);
            Mode = enMode.Update;
        }

        public clsSubscriptionPeriod()
        {
            SubscriptionPeriodID = -1;
            PersonID = -1;
            PaymentID = -1;
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
            Status = enSubscriptionPeriodStatus.Active;
            CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }

        public static clsSubscriptionPeriod Find(int SubscriptionPeriodID)
        {

            int PersonID = -1; int PaymentID = -1; DateTime StartDate = DateTime.Now, EndDate = DateTime.Now; short Status = 1; int CreatedByUserID = -1;

            if (clsSubscriptionPeriodData.GetSubscriptionPeriodInfoByID( SubscriptionPeriodID, ref PersonID, ref PaymentID, ref StartDate, ref EndDate, ref Status, ref CreatedByUserID))
            {
                return new clsSubscriptionPeriod(SubscriptionPeriodID, PersonID, PaymentID, StartDate, EndDate,(enSubscriptionPeriodStatus) Status, CreatedByUserID);
            }
            return null;

        }

        private bool _AddNewSubscriptionPeriod()
        {
            this.SubscriptionPeriodID = clsSubscriptionPeriodData.AddNewSubscriptionPeriod(PersonID, PaymentID, StartDate, EndDate,(short) Status, CreatedByUserID);
            return (this.SubscriptionPeriodID != -1);

        }

        private bool _UpdateSubscriptionPeriod()
        {
            return clsSubscriptionPeriodData.UpdateSubscriptionPeriod(SubscriptionPeriodID, PersonID, PaymentID, StartDate, EndDate, (short)Status, CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSubscriptionPeriod())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateSubscriptionPeriod();
            }
            return false;
        }

        public static bool DeleteSubscriptionPeriod(int SubscriptionPeriodID)
        {
            return clsSubscriptionPeriodData.DeleteSubscriptionPeriod(SubscriptionPeriodID);
        }

        public static DataTable GetAllSubscriptionPeriods()
        {
            return clsSubscriptionPeriodData.GetAllSubscriptionPeriods();
        }

        public static bool IsSubscriptionPeriodExist(int SubscriptionPeriodID)
        {
            return clsSubscriptionPeriodData.IsSubscriptionPeriodExist(SubscriptionPeriodID);
        }

       
        public static bool IsPersonHaveActiveSubscriptionPeriod(int PersonID)
        {
            return clsSubscriptionPeriodData.IsPersonHaveActiveSubscriptionPeriod(PersonID);
        }

        public  bool SetCancel()
        {
            return clsSubscriptionPeriodData.SetCancelSubscriptionPeriod(this.SubscriptionPeriodID);
        }
    }
}
