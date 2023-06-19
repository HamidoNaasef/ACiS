namespace ACiS.Models
{
    public class GuestProfesor: Professor
    {
        public string University { get; set; } = string.Empty;

        public Faculity? faculty { get; set; }
    }
}
