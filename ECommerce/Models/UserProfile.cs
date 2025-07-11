using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(2048)]
        [Url(ErrorMessage = "Invalid URL.")]
        public string? AvatarUrl { get; set; }

        [Phone(ErrorMessage = "Invalid phone number.")]
        [StringLength(20)]
        public string? Phone { get; set; }

        [Required]
        [StringLength(300)]
        public string Address { get; set; }

        public bool DarkModeEnabled { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; }

    }
}
