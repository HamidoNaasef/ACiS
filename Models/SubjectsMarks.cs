namespace ACiS.Models
{
    public class SubjectsMarks
    {
        public int Id { get; set; }

        public Student? student { get; set; }

        public Subject? subject { get; set; }

        public int ExamMark { get; set; }

        public int FinalMark { get; set; }

        public bool IsPassed { get; set; }// we don't need it now

        public string Description { get; set; } = String.Empty;


    }
}
