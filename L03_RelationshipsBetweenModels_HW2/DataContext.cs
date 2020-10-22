using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace L03_RelationshipsBetweenModels_HW2
{
    class DataContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=L03_HW2db; Trusted_Connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Representing a many-to-many relationship 
            // by adding the join entity type and mapping two separate one-to-many relationships.
            modelBuilder.Entity<EmployeeTask>()
                .HasKey(t => new { t.EmployeeId, t.TaskId });

            modelBuilder.Entity<EmployeeTask>()
                .HasOne(et => et.Employee)
                .WithMany(e => e.EmployeeTasks)
                .HasForeignKey(et => et.EmployeeId);

            modelBuilder.Entity<EmployeeTask>()
               .HasOne(et => et.Task)
               .WithMany(t => t.EmployeeTasks)
               .HasForeignKey(et => et.TaskId);

            modelBuilder.Entity<Task>().Property(p => p.CreatingDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}
