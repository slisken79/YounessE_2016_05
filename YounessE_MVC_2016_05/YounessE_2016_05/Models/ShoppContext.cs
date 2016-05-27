using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace YounessE_2016_05.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }

        public StoreContext() : base("MyNewStoreDB")
        {
            Database.SetInitializer(new StoreInitializer());
        }
    }

    public class StoreInitializer : DropCreateDatabaseAlways<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var stores = new List<Store>
            {
                new Store
                {
                    Name = "Yves Rocher",
                    Address = "StrandbadsVägen 33 , 25252 HBG",
                    Products = new List<Product>
                    {
                        new Product
                        {
                            Name = "Shampoo",
                            ProductText = "Very Good For The Hair.",
                            ProductNumber = "p-12",
                            ProductsInStock = 10,
                            Price = 5
                        },
                        new Product
                        {
                            Name = "Hand Creme",
                            ProductText = "Very Good For The hands.",
                            ProductNumber = "p-24",
                            ProductsInStock = 52,
                            Price = 7
                        }
                    }
                },
                new Store
                {
                    Name = "The Body Shop",
                    Address = "Aklejagatan 2 , 25845 Lund",
                    Products = new List<Product>
                    {
                        new Product
                        {
                            Name = "Douche Gele",
                            ProductText = "Very Good For The body.",
                            ProductNumber = "p-15",
                            ProductsInStock = 80,
                            Price = 19
                        },
                        new Product
                        {
                            Name = "Mascara",
                            ProductText = "Very Good For The Eyes.",
                            ProductNumber = "p-17",
                            ProductsInStock = 68,
                            Price = 8
                        }
                    }
                }
            };
            context.Stores.AddRange(stores);
            context.SaveChanges();
        }
    }
}