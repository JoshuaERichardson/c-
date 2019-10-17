using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormSubmission.Models
{
    public class User
    {
        [Required(ErrorMessage = "Please enter your First Name")]
        [MinLength(4, ErrorMessage = "First Name is Required")]
        public string FirstName { get; set; }
        
        [MinLength(4, ErrorMessage = "Last Name be at least 4 characters")]
        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }
        
        [Range(1,99,ErrorMessage = "Enter a valid age")]
        public int Age { get; set; }
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        
        [Required(ErrorMessage = "Please enter an email address")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Enter a password")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        public string Password { get; set; }    
    }
}