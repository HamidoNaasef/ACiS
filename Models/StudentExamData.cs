namespace ACiS.Models
{
    public class StudentExamData
    {
        public int Id { get; set; }
        
        public Student? student { get; set; }

        public int? SettingNumber { get; set; }// will be null at first then will be filled

        public Status? ThisYearStatus { get; set; } //the status of the student of this acadymic year

        public Stage? stage { get; set; }

        public SchoolYear? year { get; set; }

        public string Descrption { get; set; } = string.Empty;
    }
}
