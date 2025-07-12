using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class ApplicationUser : IdentityUser
    {
        [InverseProperty("User")]
        public virtual UserProfile UserProfile { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = [];
    }

}
