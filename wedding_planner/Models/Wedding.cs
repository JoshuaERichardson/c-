using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace wedding_planner.Models
    {
        public class Wedding
        {
            // General class setup as follows
            [Key]
            public int WeddingId { get; set; }
            [Required]
            [MinLength(5)]
            public string Idea { get; set; }
            [Required]
            public string Owner { get; set; }
            // Many to many setup as follows
            public List<UserWedding> WeddingToJoin { get; set; }
        }
           
    }