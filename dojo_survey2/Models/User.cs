using System.ComponentModel.DataAnnotations;
namespace dojo_survey2.Models
{
    public class User
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set;}

        [Required]
        public string Location { get; set;}

        [Required]
        [Display(Name = "Favorite Language")]
        public string Language { get; set;}

        [MinLength(20)]
        public string Comment { get; set;}

    }
}