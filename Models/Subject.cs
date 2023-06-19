namespace ACiS.Models
{
    public class Subject
    {
        public int Id { get; set; }

        public int AcademicCode { get; set; }

        public string ArabicName { get; set; } = string.Empty;

        public string EnglishName { get; set; } = string.Empty;

        public Stage? stage { get; set; }
        
        public GradingCriteria? gradingCriteria { get; set; }


    }
}
