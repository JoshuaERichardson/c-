using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace ecommerce.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        [Required]
        [Range(0,1000000)]
        public int QuantityOrdered { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}