using LibraryBook_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook_Buisness
{
    public class Setting
    {
        public static byte DefualtBorrrowDays
        {
            get =>  SettingData.GetDefualtBorrrowDays();

            set => SettingData.SetDefualtBorrrowDays(value);
  
        }

        public static float DefaultFinePerDay
        {
            get => SettingData.GetDefaultFinePerDay();

            set => SettingData.SetDefaultFinePerDay(value);
            
        }

        public static float DefaultMonthlySubscriptionAmount
        {
            get => SettingData.GetDefaultMonthlySubscriptionAmount();

            set => SettingData.SetDefaultMonthlySubscriptionAmount(value);
        }

        public static float DefaultAnnualSubscriptionAmount
        {
            get => SettingData.GetDefaultAnnualSubscriptionAmount();

            set => SettingData.SetDefaultAnnualSubscriptionAmount(value);
        }

        public static byte DefaultNumberOfBorrowedBooks
        {
            get => SettingData.GetDefaultNumberOfBorrowedBooks();

            set => SettingData.SetDefaultNumberOfBorrowedBooks(value);
        }

        public static byte DefaultNumberOfDaysWaitingForABookReserved
        {
            get => SettingData.GetDefaultNumberOfDaysWaitingForABookReserved();

            set => SettingData.SetDefaultNumberOfDaysWaitingForABookReserved(value);
        }

        public static bool IsShowConfigurationSettings
        {
            get => SettingData.GetIsShowConfigurationSettings();

            set => SettingData.SetIsShowConfigurationSettings(value);
        }

        public static byte DefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod
        {
            get => SettingData.GetDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod();

            set => SettingData.SetDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod(value);
        }
    }
}
