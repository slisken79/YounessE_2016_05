using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YounessE_MVC_2016_05.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProductText { get; set; }
        public int ProductNumber { get; set; }
        public int Price { get; set; }
        public int ProductsInStock{ get; set; }
       

    }
}