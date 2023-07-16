using ECommerceShoppingCartAppASPNET7.Models;
using System;
using System.Linq;

namespace ECommerceShoppingCartAppASPNET7.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ProductContext context)
        {
            context.Database.EnsureCreated();
            //Look for any products
            if (context.Products.Any())
            {
                return;//DB has been seeded
            }
            var products = new Product[]
            {
                  new Product()
                  {
                      Id = "1",
                     Name = "Aconitum",
                      Photo = "Aconitum.jpg",
                      Price = 2.80
                  },

                new Product()
                {
                    Id="2",
                    Name = "African Daisy",
                    Photo = "AfricanDaisy.jpg",
                    Price = 3.80
                },
                new Product()
                {
                    Id="3",
                    Name = "Begonia",
                    Photo = "Begonia.jpg",
                    Price = 3.80
                },
                  new Product()
                  {
                      Id="4",
                      Name = "Chrysanthemum",
                      Photo = "Chrysanthemum.jpg",
                      Price = 3.60
                  },
                new Product()
                {
                    Id="5",
                    Name = "Dahlia",
                    Photo = "Dahlia.jpg",
                    Price = 6.80
                },
                new Product()
                {
                    Id="6",
                    Name = "Daisy",
                    Photo = "Daisy.jpg",
                    Price = 1.68
                },
                  new Product()
                  {
                      Id="7",
                      Name = "Echinacea",
                      Photo = "Echinacea.jpg",
                      Price = 3.80
                  },
                  new Product()
                  {
                      Id="8",
                      Name = "ForgetMeNot",
                      Photo = "ForgetMeNot.jpg",
                      Price = 3.45
                  },
                new Product()
                {
                    Id = "9",
                    Name = "Jasmine",
                    Photo = "Jasmine.jpg",
                    Price = 3.80
                }
                  
            };
            foreach (Product p in products)
            {
                context.Products.Add(p);
            }
            context.SaveChanges();

        }
    }
}
