using DocesLila.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DocesLila.Context
{
    public class DocesLilaContext : DbContext
    {
        public DocesLilaContext(DbContextOptions<DocesLilaContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        //public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
