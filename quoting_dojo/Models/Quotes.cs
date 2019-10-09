using System.ComponentModel.DataAnnotations;

namespace quoting_dojo.Models

{
    public class Quotes
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }

        
        [MinLength(1)]
        public string Quote { get; set; }
    }
}