using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace YounessE_MVC_2016_05.Models
{
    public class ShoppContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
           
      
            public ShoppContext() : base("ShoppDB")
            {
                Database.SetInitializer(new ShoppInitializer());
            }

        }

        internal class ShoppInitializer : DropCreateDatabaseAlways<ShoppContext>
        {
            protected override void Seed(ShoppContext ctx)
            {
                List<Store> store1 = new List<Store>()
            {
                new Store() {StoreId = 1, Name = "BodyShop", Address = "Strandbadsvägen 13b, 25228 Helsingborg",
                Products = new List<Product>()
                { new Product() {
                    ProductId = 1,
                    Name = "Body Lotion",
                    ProductText = "Very good for the skin",
                    ProductNumber = 112,
                    Price = 30,
                    ProductsInStock = 150
                },
                new Product()
                {
                    ProductId = 2,
                    Name = "Shampoo",
                    ProductText = "Very good for the hair",
                    ProductNumber = 222,
                    Price = 45,
                    ProductsInStock = 140
                }}}};
                 ctx.Stores.AddRange(store1);
                 ctx.SaveChanges();
            List<Store> store2 = new List<Store>()
            {
                new Store() {StoreId = 1, Name = "Yves Rocher", Address = "Aklejagatan 5, 25228 Helsingborg",
                Products = new List<Product>()
                { new Product() {
                    ProductId = 1,
                    Name = "Hand Creme",
                    ProductText = "Very good for the hands",
                    ProductNumber = 105,
                    Price = 25,
                    ProductsInStock = 102
                },
                new Product()
                {
                    ProductId = 2,
                    Name = "Mascara",
                    ProductText = "Very good for the Eyes",
                    ProductNumber = 342,
                    Price = 27,
                    ProductsInStock = 179
                }}}};
            ctx.Stores.AddRange(store2);
            ctx.SaveChanges();

        }          
    }
}
   