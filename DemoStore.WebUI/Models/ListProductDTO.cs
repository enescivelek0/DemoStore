using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoStore.WebUI
{
    public class ListProductDTO
    {
        public int? CategoryId {get; set;}
        public string? ProductName {get; set;}
        public decimal? ProductPrice {get; set;}
        public int? ProductStock {get; set;}
        public bool? ProductStatus {get; set;}
    }
}
