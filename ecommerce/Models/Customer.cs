using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ecommerce.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }        
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public List<Order> CustomerOrders { get; set; }
    }
}