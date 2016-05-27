using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YounessE_2016_05.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required, MaxLength(20)]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        [MaxLength(100)]
        public string ProductText { get; set; }
        [Required,My]
        public string ProductNumber { get; set; }
        [Required, Range(0, 300)]
        public int Price { get; set; }
        [Required, Range(0, 1500)]
        public int ProductsInStock { get; set; }
        public virtual int StoreId { get; set; }
     
    }
}