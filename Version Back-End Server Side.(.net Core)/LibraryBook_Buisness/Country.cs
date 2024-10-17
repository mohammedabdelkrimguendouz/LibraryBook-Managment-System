
using LibraryBook_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook_Buisness
{
    public class Country
    {
        public CountryDTO countryDTO
        {
            get => new CountryDTO(this.CountryID, this.CountryName);
        }
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        private Country(CountryDTO countryDTO)
        {
            this.CountryID = countryDTO.CountryID;
            this.CountryName = countryDTO.CountryName
            ;
        }

        public static Country Find(int CountryID)
        {

            CountryDTO countryDTO = CountryData.GetCountryInfoByID(CountryID);

            if (countryDTO != null)
            {
                return new Country(countryDTO);
            }
            return null;

        }

       

        public static Country Find(string CountryName)
        {
            CountryDTO countryDTO = CountryData.GetCountryInfoByName(CountryName);

            if (countryDTO != null)
            {
                return new Country(countryDTO);
            }
            return null; ;

        }

        public static List<CountryDTO> GetAllCountries()
        {
            return CountryData.GetAllCountries();
        }


    }
}
