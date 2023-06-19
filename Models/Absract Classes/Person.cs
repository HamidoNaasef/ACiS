namespace ACiS.Models
{
    public abstract class Person
    {
        public int Id { get; set; }

        public int AcadmicCode { get; set; }

        public string ArabicFirstName { get; set; } = string.Empty;

        public string ArabicLastName { get; set; } = string.Empty;

        public string EnglishFirstName { get; set; } = string.Empty;

        public string EnglishLastName { get; set; } = string.Empty;

        public string Gender { get; set; } = string.Empty;

        public DateTime BirthDate { get; set; }

        public Country? BirthCountry { get; set; }

        public City? BirthCity { get; set; }

        public Country? LivingCountry { get; set; }

        public City? LivingCity { get; set; }

        public Country? Nationality { get; set; }

        public int SSID { get; set; }

        public string MobileNumber { get; set; } = string.Empty;

        public string TelephoneNumber { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Adress { get; set; } = string.Empty;

        public string PostalCode { get; set; } = string.Empty;

        public string PostalAdress { get; set; } = string.Empty;

    }
}
