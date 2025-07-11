using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class ProductImage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Url(ErrorMessage = "Invalid URL.")]
        [StringLength(2048)]
        public string Url { get; set; }

        public bool IsPrimary { get; set; }

        [Range(0, int.MaxValue)]
        public int OrderIndex { get; set; }

        [Required]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
