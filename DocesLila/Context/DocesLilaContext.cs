using DocesLila.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DocesLila.Context
{
    public class DocesLilaContext : DbContext
    {
        public DocesLilaContext(DbContextOptions<DocesLilaContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Definindo chave primária
            modelBuilder.Entity<Product>()
                .HasKey(p => p.Id);
            //Definindo tamanho das propriedades da tabela de produto
            modelBuilder.Entity<Product>()
                .Property(p => p.Title)
                .HasMaxLength(100);
            modelBuilder.Entity<Product>()
                .Property(p => p.Description)
                .HasMaxLength(500);
            modelBuilder.Entity<Product>()
                .Property(p => p.Batch)
                .HasMaxLength(5);
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(3, 2);
            modelBuilder.Entity<Product>()
                .Property(p => p.ExpireDate)
                .HasColumnType("Date");
            modelBuilder.Entity<Product>()
                .Property(p => p.RegistrationDate)
                .HasColumnType("Date");

            modelBuilder.Entity<Product>().HasData(SeedTable());
        }

        private IList<Product> SeedTable()
        {
            return new Product[]
            {
                new Product
                {
                    Id=1,
                    Title="Casadinho",
                    Description="gostoso",
                    Quantity=300,
                    Price=10.00,
                    RegistrationDate=DateTime.Now,
                    ExpireDate=DateTime.Now.AddDays(3)
                },
                new Product
                {
                    Id=2,
                    Title="Bala de coco",
                    Description="muito bom",
                    Quantity=200,
                    Price=8.00,
                    RegistrationDate=DateTime.Now,
                    ExpireDate=DateTime.Now.AddDays(4)
                },
                new Product
                {
                    Id=3,
                    Title="Rosquinha",
                    Description="Delicia",
                    Quantity=120,
                    Price=5.00,
                    RegistrationDate=DateTime.Now,
                    ExpireDate=DateTime.Now.AddDays(10)
                },
                new Product
                {
                    Id=4,
                    Title="Suspiro",
                    Description="Doce",
                    Quantity=500,
                    Price=4.00,
                    RegistrationDate=DateTime.Now,
                    ExpireDate=DateTime.Now.AddDays(15)
                },
                new Product
                {
                    Id=5,
                    Title="Biscoito de Nozes",
                    Description="Saboroso",
                    Quantity=82,
                    Price=12.00,
                    RegistrationDate=DateTime.Now,
                    ExpireDate=DateTime.Now.AddDays(2)
                },
                new Product
                {
                    Id=6,
                    Title="Alfajor",
                    Description="Chocolate",
                    Quantity=40,
                    Price=20.00,
                    RegistrationDate=DateTime.Now,
                    ExpireDate=DateTime.Now.AddDays(1)
                },
                new Product
                {
                    Id=7,
                    Title="Goiabinha",
                    Description="Macio",
                    Quantity=234,
                    Price=6.00,
                    RegistrationDate=DateTime.Now,
                    ExpireDate=DateTime.Now.AddDays(7)
                }
            };
        }
    }
}
