using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DVLD_Buisness.Global_Classes
{
    public class clsValidation
    {
        public static bool ValidateEmail(string EmailAddress)
        {
            var Pattern = @"^[a-zA-Z0-9._%+-]{6,30}@gmail\.com$";
            var regex =new Regex(Pattern);
            return regex.IsMatch(EmailAddress);
        }
        public static bool ValidateInteger(string Number)
        {
            var Pattern = @"^\d+$";
            var regex = new Regex(Pattern);
            return regex.IsMatch(Number);
        }
        public static bool validateFloat(string Number)
        {
            var Pattern = @"^-?\d+(\.\d+)?$";
            var regex = new Regex(Pattern);
            return regex.IsMatch(Number);
        }

       
        public static bool IsNumber(string Number)
        {
            return (ValidateInteger(Number)||validateFloat(Number)) ;
        }

        public static bool ValidateISBN10(string ISBN)
        {
            var Pattern = @"^\d{9}[\d|X]$";
            var regex = new Regex(Pattern);
            return regex.IsMatch(ISBN);
        }
        public static bool ValidateISBN13(string ISBN)
        {
            var Pattern = @"^\d{13}$";
            var regex = new Regex(Pattern);
            return regex.IsMatch(ISBN);
        }

        public static bool IsISBN(string ISBN)
        {
            return ValidateISBN10(ISBN) || ValidateISBN13(ISBN);
        }

    }
}
