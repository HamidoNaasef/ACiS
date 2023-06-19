using ACiS.Models;

namespace ACiS.ViewModels
{
    public class UserAuthorityVM
    {
        public int Id { get; set; }

        public string ArabicName { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public int AuthorityId { get; set; }

        public IList<Authority>? authorities { get; set; }
    }
}
