using Microsoft.AspNetCore.Identity;

namespace ECommerce.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual UserProfile Profile { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = [];
    }

}
