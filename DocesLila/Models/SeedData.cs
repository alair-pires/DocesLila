using DocesLila.Context;
using DocesLila.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace DocesLila.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DocesLilaContext(serviceProvider.GetRequiredService<DbContextOptions<DocesLilaContext>>()))
            {
                if (context.Products.Any())
                {
                    return;
                }
                context.Products.AddRange(
                    new Product
                    {
                        Title = "Casadinho",
                        Description = "gostoso",
                        Quantity = 300,
                        Price = 10.00m,
                        RegistrationDate = DateTime.Now,
                        ExpireDate = DateTime.Now.AddDays(3)
                    },
                    new Product
                    {
                        Title = "Bala de coco",
                        Description = "muito bom",
                        Quantity = 200,
                        Price = 8.00m,
                        RegistrationDate = DateTime.Now,
                        ExpireDate = DateTime.Now.AddDays(4)
                    },
                    new Product
                    {
                        Title = "Rosquinha",
                        Description = "Delicia",
                        Quantity = 120,
                        Price = 5.00m,
                        RegistrationDate = DateTime.Now,
                        ExpireDate = DateTime.Now.AddDays(10)
                    },
                    new Product
                    {
                        Title = "Suspiro",
                        Description = "Doce",
                        Quantity = 500,
                        Price = 4.00m,
                        RegistrationDate = DateTime.Now,
                        ExpireDate = DateTime.Now.AddDays(15)
                    },
                    new Product
                    {
                        Title = "Biscoito de Nozes",
                        Description = "Saboroso",
                        Quantity = 82,
                        Price = 12.00m,
                        RegistrationDate = DateTime.Now,
                        ExpireDate = DateTime.Now.AddDays(2)
                    },
                    new Product
                    {
                        Title = "Alfajor",
                        Description = "Chocolate",
                        Quantity = 40,
                        Price = 20.00m,
                        RegistrationDate = DateTime.Now,
                        ExpireDate = DateTime.Now.AddDays(1)
                    },
                    new Product
                    {
                        Title = "Goiabinha",
                        Description = "Macio",
                        Quantity = 234,
                        Price = 6.00m,
                        RegistrationDate = DateTime.Now,
                        ExpireDate = DateTime.Now.AddDays(7)
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
