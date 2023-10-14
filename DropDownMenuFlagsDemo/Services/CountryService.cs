using DropDownMenuFlagsDemo.Data;


namespace DropDownMenuFlagsDemo.Services
{
    public class CountryService
    {
       
        public static List<CountryDto> GetCountries()
        {
            List<CountryDto> countriesList = new List<CountryDto>()
                {
                new CountryDto()
                {
                    Id = 1,
                    Country = "Bulgaria",
                    CountryCode = "BG"
                },
                 new CountryDto()
                 {
                    Id = 2,
                    Country = "USA",
                    CountryCode = "US"
                 },
                new CountryDto()
                {
                    Id = 3,
                    Country = "China",
                    CountryCode = "CN"
                }
                };

            return countriesList;
        }
    }


}