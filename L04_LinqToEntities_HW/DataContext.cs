using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace L04_LinqToEntities_HW
{
    class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=ShopDB; Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Product 1", Description = "This is Product 1", Price = 120, IsAvailable = true },
                new Product { Id = 2, Name = "Product 2", Description = "This is Product 2", Price = 300, IsAvailable = false },
                new Product { Id = 3, Name = "Product 3", Description = "This is Product 3", Price = 125, IsAvailable = true },
                new Product { Id = 4, Name = "Product 4", Description = "This is Product 4", Price = 264, IsAvailable = true },
                new Product { Id = 5, Name = "Product 5", Description = "This is Product 5", Price = 210, IsAvailable = false },
                new Product { Id = 6, Name = "Product 6", Description = "This is Product 6", Price = 430, IsAvailable = true }
                );
        }
    }
}
