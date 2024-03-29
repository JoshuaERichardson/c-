    using System.ComponentModel.DataAnnotations;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    namespace products_and_cat.Models
    {
        public class Association
        {
            [Key]
            public int AssociationId { get; set; }
            public int ProductId { get; set; }
            public int CategoryId { get; set; }
            public Product Product { get; set; }
            public Category Category { get; set; }
        }
    }