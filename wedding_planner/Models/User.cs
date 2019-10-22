using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace wedding_planner.Models
    {
    public class User
    {
        // General User table setup as follows
        [Key]
        public int UserId { get; set; }
        [Required]
        [MinLength(2)]
        public string Name { get; set; }


        [Required]
        [MinLength(2)]
        public string Alias { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        //Will not be mapped to users table as follows!
        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name="Password")]
        public string Confirm { get; set; }
        [NotMapped]
        [Display(Name="Email")]
        public string CheckEmail { get; set; }
        [NotMapped]
        [Display(Name="Password")]
        [DataType(DataType.Password)]
        public string CheckPassword { get; set; }

        // Many to many setup as follows
        public List<UserWedding> UserToJoin { get; set; }

    }
}