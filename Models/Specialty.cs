namespace ACiS.Models
{
    public class Specialty
    {
        public int  Id{ get; set; }
        
        public string Name { get; set; } = string.Empty;

        public Department? department { get; set; }

        public Division? division { get; set; }

    }
}