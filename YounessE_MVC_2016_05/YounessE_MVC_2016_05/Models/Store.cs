using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YounessE_MVC_2016_05.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Product> Products { get; set; }


    }
}