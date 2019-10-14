using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace chefs_and_dishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId { get; set; }


        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DOB { get; set; }

        //navigation
        public List<Dish> CreatedDishes { get; set; }

    }
}