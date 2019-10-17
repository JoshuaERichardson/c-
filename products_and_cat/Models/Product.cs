    using System.ComponentModel.DataAnnotations;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace products_and_cat.Models
    {
        public class Product
        {
            // auto-implemented properties need to match the columns in your table
            // the [Key] attribute is used to mark the Model property being used for your table's Primary Key
            [Key]
            public int ProductId { get; set; }
            [Required]
            [MinLength(3)]
            public string Name { get; set; }
            [MinLength(10)]
            public string Description { get; set; }
            [Required]
            [Range(0, 1000000)]
            public double Price { get; set; }
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;
            public List<Association> ProductToCat { get; set; }
        }
    }