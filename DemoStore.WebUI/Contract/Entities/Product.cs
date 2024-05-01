using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoStore.WebUI
{
    public partial class Product
    {
        [Required]
        [Key]
        public int ProductId { get; set; }

        public int? CategoryId { get; set; }

        [StringLength(50)]
        public string? ProductName { get; set; }

        public decimal? ProductPrice { get; set; }

        public int? ProductStock { get; set; }

        public bool? ProductStatus { get; set; }

        public virtual Category? Category { get; set; }

        public string? ProductImageUrl { get; set; }
    }
}
