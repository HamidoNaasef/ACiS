namespace ACiS.Models
{
    public class Department
    {
        public int Id { get; set; }

        public int AcademicCode { get; set; }

        public string ArabicName { get; set; } = string.Empty;

        public string EnglishName { get; set; } = string.Empty;
    }
}