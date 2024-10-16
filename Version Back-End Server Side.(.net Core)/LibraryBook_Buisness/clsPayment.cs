using LibraryBook_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook_Buisness
{
    public class clsPayment
    {
        public enum enPaymentReason { SubscriptionPeriod=1 ,Fine=2 }
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        public int PaymentID { get; set; }
        public DateTime PaymentDate { get; set; }
        public float PaymentAmount { get; set; }
        public enPaymentReason PaymentReason { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo;

        private clsPayment(int PaymentID, DateTime PaymentDate, float PaymentAmount, enPaymentReason PaymentReason, string Notes, int CreatedByUserID)
        {
            this.PaymentID = PaymentID;
            this.PaymentDate = PaymentDate;
            this.PaymentAmount = PaymentAmount;
            this.PaymentReason = PaymentReason;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.Find(CreatedByUserID);
            Mode = enMode.Update;
        }

        public clsPayment()
        {
            PaymentID = -1;
            PaymentDate = DateTime.Now;
            PaymentAmount = 0;
            PaymentReason = enPaymentReason.SubscriptionPeriod;
            Notes = "";
            CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }

        public static clsPayment Find(int PaymentID)
        {

            DateTime PaymentDate = DateTime.Now; float PaymentAmount = 0; short PaymentReason = 1; string Notes = ""; int CreatedByUserID = -1;

            if (clsPaymentData.GetPaymentInfoByID( PaymentID, ref PaymentDate, ref PaymentAmount, ref PaymentReason, ref Notes, ref CreatedByUserID))
            {
                return new clsPayment(PaymentID, PaymentDate, PaymentAmount,(enPaymentReason) PaymentReason, Notes, CreatedByUserID);

            }
            return null;

        }

        private bool _AddNewPayment()
        {
            this.PaymentID = clsPaymentData.AddNewPayment(PaymentDate, PaymentAmount,(short) PaymentReason, Notes, CreatedByUserID);
             return (this.PaymentID != -1);
        }

        private bool _UpdatePayment()
        {
            return clsPaymentData.UpdatePayment(PaymentID, PaymentDate, PaymentAmount, (short)PaymentReason, Notes, CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPayment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdatePayment();
            }
            return false;
        }

        public static bool DeletePayment(int PaymentID)
        {
            return clsPaymentData.DeletePayment(PaymentID);
        }

        public static DataTable GetAllPayments()
        {
            return clsPaymentData.GetAllPayments();
        }

        public static bool IsPaymentExist(int PaymentID)
        {
            return clsPaymentData.IsPaymentExist(PaymentID);
        }

    }
}
