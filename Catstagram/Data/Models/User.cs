using Microsoft.AspNetCore.Identity;

namespace Catstagram.Data.Models
{
    public class User : IdentityUser
    {
        public IEnumerable<Cat> Cats { get; } = new HashSet<Cat>();
    }
}

