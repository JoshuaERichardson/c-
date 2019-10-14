using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace chefs_and_dishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [Required]
        public string DishName { get; set; }

        [Required]
        [Range(0,10000000000)]
        public int Calories { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Tastiness { get; set; }


        // owning to chefs
        [Required]
        public int ChefId { get; set; }
        //navigation
        public Chef Creator { get; set; }
    }
}