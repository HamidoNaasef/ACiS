namespace ACiS.Models
{
    public class City
    {
        public int Id { get; set; }

        public string ArabicName { get; set; } = string.Empty;

        public string EnglishName { get; set; } = string.Empty;

        public Country? CountryBelongTo { get; set; }
    }
}