using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace L02_FluentAPIAndDataAnnotations_HW1
{
    class DataContext : DbContext
    {
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=L07_HW1db; Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().ToTable("Orders").HasKey(p => p.Id).HasName("PK_Orders_Id");
            modelBuilder.Entity<Order>().Property(o => o.Product).IsRequired();
            modelBuilder.Entity<Order>().Property(o => o.Quantity).IsRequired();
        }
    }
}
