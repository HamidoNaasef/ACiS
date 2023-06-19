namespace ACiS.Models
{
    public class SubjectProff
    {
        public int Id { get; set; }

        public Professor? Professor { get; set; }

        public Subject? subject { get; set; }

        public SchoolYear? Year { get; set; }
        
        public int AutoLiftingDegree { get; set;}
    }
}
