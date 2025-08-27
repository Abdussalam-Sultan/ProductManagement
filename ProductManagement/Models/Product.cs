using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProductManagement.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        [DisplayName("Product Name")]
        public string? Name { get; set; }
        [MaxLength(100)]
        [DisplayName("Product Description")]
        public string? Description { get; set; }
        public DateOnly Date {  get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string? Category { get; set; }


    }
}
