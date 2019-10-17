using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ecommerce.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [MinLength(2)]
        public string Name { get; set; } 
        [MinLength(5)]
        public string Image { get; set; }
        [MinLength(10)]
        public string Description { get; set; }
        
        public int Quantity { get; set; }
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public List<Order> ProductOrders { get; set; }
    }
}