using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CatalogAPI.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "You must inform the product name")]
        [StringLength(125, ErrorMessage = "Your name must have between 1 and 125 characters")]
        public string? Name { get; set; }

        [Required]
        [StringLength(300, ErrorMessage = "The description must have a maximum of 300 characters ")]
        public string? Description { get; set; }

        [Required (ErrorMessage = "It's required to enter a price.")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1, 10000, ErrorMessage = "The price cannot exceed {2} and must be higher than {1}")]
        public decimal Price { get; set; }
        [Required]
        [StringLength(300)]
        public string? ImageUrl { get; set; }
        public float Stock { get; set; }
        public DateTime RegistryData { get; set; }
        public int CategoryId { get; set; }
        [JsonIgnore]
        public Category? Category { get; set; }
    }
}
