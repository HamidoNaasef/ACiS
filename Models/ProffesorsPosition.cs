namespace ACiS.Models
{
    public class ProffesorsPosition
    {
        public int Id { get; set; }

        public Professor? Professor { get; set; }

        public Position? Position { get; set; }

        public DateTime Date { get; set; }


    }
}
