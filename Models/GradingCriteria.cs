namespace ACiS.Models
{
    public class GradingCriteria
    {
        public int Id{ get; set; }

        public string Name { get; set; } = string.Empty;

        public int MaxGrade { get; set; }

        public int A { get; set; }//ممتاز:

        public int B { get; set; }//جيد جدا

        public int C { get; set; }//جيد

        public int D { get; set; }//مقبول

        public int MinGrade { get; set; }// ضعيف




    }
}