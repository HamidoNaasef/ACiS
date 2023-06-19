namespace ACiS.Models
{
    public class Division
    {
        public int Id{ get; set; }
        
        public int AcademicCode{ get; set; }

        public string ArabicName { get; set; } = string.Empty;
        
        public string EnglishName { get; set; } = string.Empty;

        public Department? department { get; set; }

        public string Gender { get; set; } = string.Empty;


    }
}