using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BestStoreMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        [MaxLength(100)]  
        public string Brand { get; set; } = "";
        [MaxLength(100)]
        public string category { get; set; } = "";
        [Precision(16,2)]
        public Decimal Price { get; set; } 
        public string Description { get; set; } = "";
        [MaxLength (100)]
        public string ImageFileName { get; set; } = "";
        public DateTime CreatedAt {  get; set; } 

    }
}
