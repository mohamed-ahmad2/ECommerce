
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class ContactMessage
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email format.")]
        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(150)]
        public string? Subject { get; set; }

        [Required(ErrorMessage = "Message is required.")]
        [StringLength(2000)]
        public string Message { get; set; }

        public DateTime ReceivedAt { get; set; } = DateTime.Now;
    }
}
