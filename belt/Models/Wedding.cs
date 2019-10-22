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
            [MinLength(2)]
            public string WOne { get; set; }
            [Required]
            [MinLength(2)]
            public string WTwo { get; set; }
            [Required]
            [DataType(DataType.Date)]
            public DateTime Date { get; set; }
            [DataType(DataType.PostalCode)]
            public string Address { get; set; }
            [Required]
            public string Owner { get; set; }
            // Many to many setup as follows
            public List<UserWedding> WeddingToJoin { get; set; }
        }
           
    }