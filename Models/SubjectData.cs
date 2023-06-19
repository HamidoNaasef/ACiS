namespace ACiS.Models
{
    public class SubjectData
    {
        public int Id { get; set; }

        public Subject? subject { get; set; }

        public Division? division { get; set; }

        public Stage? stage { get; set;}
    }
}
