using System.ComponentModel.DataAnnotations;

namespace BestStoreMVC.Models
{
    public class ProductDto
    {
        [Required, MaxLength(100)]
        public string Name { get; set; } = "";
        [Required,MaxLength(100)]
        public string Brand { get; set; } = "";
        [Required,MaxLength(100)]
        public string category { get; set; } = "";
        [Required]
        public Decimal Price { get; set; }
        [Required]
        public string Description { get; set; } = "";
        
        public IFormFile? ImageFile { get; set; }
    }
}
