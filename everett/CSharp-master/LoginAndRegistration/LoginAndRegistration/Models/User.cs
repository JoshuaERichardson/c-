using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAndRegistration.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Enter your first name")]
        [MinLength(2, ErrorMessage = "First name must be at least 2 characters")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "First name must be letters only")]
        public string first_name { get; set; }

        [Required(ErrorMessage = "Enter your last name")]
        [MinLength(2, ErrorMessage = "Last name must be at least 2 characters")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Last name can only have letters!")]
        public string last_name { get; set; }

        [Required(ErrorMessage = "Enter your email")]
        [EmailAddress(ErrorMessage ="We need a valid email address")]
        public string email { get; set; }

        [Required(ErrorMessage = "Enter a password")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        public string password { get; set; }

        [Compare("password", ErrorMessage = "Your passwords do not match, the horror!")]
        public string password2 { get; set; }
    }
}