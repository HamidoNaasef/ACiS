namespace ACiS.Models
{
    public class Authority
    {

        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int? Year { get; set; }

        public SubjectData? term { get; set; }

        public Subject? Subject { get; set; }



    }
}