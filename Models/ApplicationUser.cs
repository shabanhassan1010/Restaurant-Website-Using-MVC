using Microsoft.AspNetCore.Identity;

namespace MVC_PROJECT.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
