namespace ACiS.Models
{
    public class Professor: Person
    {
        public Specialty? Specialtization { get; set; }
                
        public Position? Position { get; set; }

    }
}
