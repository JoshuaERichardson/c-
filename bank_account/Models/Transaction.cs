using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace login_and_reg.Models
{
    public class Transaction
    {
        
        [Key]
        public int TransactionId { get; set; }


        [Required]
        public double Amount { get; set; }
        
        
        
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        public User Creator { get; set; }
    }
}