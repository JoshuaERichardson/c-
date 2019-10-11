using System;
using System.ComponentModel.DataAnnotations;

namespace crudelicious.Models
    {
        public class Dish
        {
            // auto-implemented properties need to match the columns in your table
            // the [Key] attribute is used to mark the Model property being used for your table's Primary Key
            [Key]
            public int DishId { get; set; }
            // MySQL VARCHAR and TEXT types can be represeted by a string
            [Required]
            public string DishName { get; set; }
            [Required]
            public string ChefName { get; set; }
            [Required]
            public int Tastiness { get; set; }
            [Required]
            public int Calories { get; set; }
            // The MySQL DATETIME type can be represented by a DateTime
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;
        }
    }