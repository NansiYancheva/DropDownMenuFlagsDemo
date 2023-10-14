namespace DropDownMenuFlagsDemo.Data
{
    public class CountryDto
    {
        public int Id { get; set; }

        public string Country { get; set; }

        public string CountryCode { get; set; }

        public string FlagUrl => $"_content/BlazorFlags/flags/{CountryCode}.png";
    }
}
