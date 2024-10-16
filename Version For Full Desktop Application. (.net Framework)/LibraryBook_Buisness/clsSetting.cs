using LibraryBook_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook_Buisness
{
    public class clsSetting
    {
        public static byte DefualtBorrrowDays
        {
            get =>  clsSettingData.GetDefualtBorrrowDays();

            set => clsSettingData.SetDefualtBorrrowDays(value);
  
        }

        public static float DefaultFinePerDay
        {
            get => clsSettingData.GetDefaultFinePerDay();

            set => clsSettingData.SetDefaultFinePerDay(value);
            
        }

        public static float DefaultMonthlySubscriptionAmount
        {
            get => clsSettingData.GetDefaultMonthlySubscriptionAmount();

            set => clsSettingData.SetDefaultMonthlySubscriptionAmount(value);
        }

        public static float DefaultAnnualSubscriptionAmount
        {
            get => clsSettingData.GetDefaultAnnualSubscriptionAmount();

            set => clsSettingData.SetDefaultAnnualSubscriptionAmount(value);
        }

        public static byte DefaultNumberOfBorrowedBooks
        {
            get => clsSettingData.GetDefaultNumberOfBorrowedBooks();

            set => clsSettingData.SetDefaultNumberOfBorrowedBooks(value);
        }

        public static byte DefaultNumberOfDaysWaitingForABookReserved
        {
            get => clsSettingData.GetDefaultNumberOfDaysWaitingForABookReserved();

            set => clsSettingData.SetDefaultNumberOfDaysWaitingForABookReserved(value);
        }

        public static bool IsShowConfigurationSettings
        {
            get => clsSettingData.GetIsShowConfigurationSettings();

            set => clsSettingData.SetIsShowConfigurationSettings(value);
        }

        public static byte DefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod
        {
            get => clsSettingData.GetDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod();

            set => clsSettingData.SetDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod(value);
        }
    }
}
