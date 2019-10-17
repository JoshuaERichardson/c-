using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace ecommerce.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }

    }
}