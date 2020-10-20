using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace L02_FluentAPIAndDataAnnotations_HW2
{
    class DataContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=L07_HW2db; Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>().HasKey(t => new { t.CourseId, t.StudentId });
            modelBuilder.Entity<StudentCourse>()
                .HasOne(p => p.Course)
                .WithMany(x => x.StudentCourses)
                .HasForeignKey(y => y.CourseId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(p => p.Student)
                .WithMany(x => x.StudentCourses)
                .HasForeignKey(y => y.StudentId);

        }
    }
}
