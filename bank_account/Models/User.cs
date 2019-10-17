using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace login_and_reg.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }


        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }


        [Required]
        [MinLength(2)]
        public string LastName { get; set; }


        [Required]
        [EmailAddress]
        //check if unique!
        public string Email { get; set; }


        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //get a matching password


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm { get; set; }


        //Navigation property
        public List<Transaction> CreatedTransactions { get; set; }
    }
}