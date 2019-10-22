    using System.ComponentModel.DataAnnotations;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;


    namespace wedding_planner.Models
    {
        public class UserWedding
        {
            // Setup on the Joining Table between User and Wedding
            [Key]
            public int UserWeddingId { get; set; }
            public int WeddingId { get; set; }
            public int UserId { get; set; }
            public Wedding Wedding { get; set; }
            public User User { get; set; }
        }
    }