using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace login_and_reg.Models
{
    public class LoginUser
    {
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [MinLength(8)]
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set;}
    }
}