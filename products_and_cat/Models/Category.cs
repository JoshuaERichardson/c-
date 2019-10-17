using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace products_and_cat.Models
    {
        public class Category
        {
            [Key]
            public int CategoryId { get; set; }
            [Required]
            [MinLength(3)]
            public string Name { get; set; }
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;
            public List<Association> CatToProduct { get; set; }
            
        }
    }