using System;
using System.ComponentModel.DataAnnotations;

namespace QuotingDojo.Models
{
    public class Quote
    {
        [Display(Name="Your Name")]
        [Required]
        [MinLength(3, ErrorMessage="Name must be at least 3 characters long")]
       public string Creator {get;set;}
       
       [Display(Name="Your Quote")]
       [Required]
       public string Content {get;set;}
    }
}