using System.ComponentModel.DataAnnotations;
namespace validating_form_submission.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        public string Fname { get; set; }

        [Required]
        [MinLength(4)]
        public string Lname { get; set; }

        [Required]
        [Range(0,double.PositiveInfinity)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }

    }
}