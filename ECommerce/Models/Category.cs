using System.ComponentModel.DataAnnotations;


namespace ECommerce.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name must be less than 100 characters.")]
        public string Name { get; set; }

        [StringLength(100, ErrorMessage = "Slug must be less than 100 characters.")]
        public string? Slug { get; set; }

        public virtual ICollection<Product> Products { get; set; } = [];
    }
}
