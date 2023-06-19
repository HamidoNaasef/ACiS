

namespace ACiS.Models
{
    public class User
    {
        public int Id { get; set; }
        
        public string ArabicName { get; set; }= string.Empty;
        
        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public Authority? authority { get; set; }// SuperAdmin(Developer) - Control Admin - Student Affairs Admin - Control Clerk - Student Affairs Clerk





    }
}
