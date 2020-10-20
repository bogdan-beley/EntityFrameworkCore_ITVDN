using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace L02_FluentAPIAndDataAnnotations_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DataContext db = new DataContext())
            {
                Student s1 = new Student { FName = "George", LName = "Talor" };
                Student s2 = new Student { FName = "Alice", LName = "King" };
                db.Students.AddRange(new List<Student> { s1, s2 });

                Course c1 = new Course { Name = ".NET Framework" };
                Course c2 = new Course { Name = "Entity Framework Core" };
                Course c3 = new Course { Name = "SQL Transaq" };
                db.Courses.AddRange(new List<Course> { c1, c2, c3 });

                db.SaveChanges();

                s1.StudentCourses.Add(new StudentCourse { CourseId = c1.Id, StudentId = s1.Id });
                s2.StudentCourses.Add(new StudentCourse { CourseId = c3.Id, StudentId = s2.Id });
                s2.StudentCourses.Add(new StudentCourse { CourseId = c2.Id, StudentId = s2.Id });
                db.SaveChanges();

                var courses = db.Courses.Include(c => c.StudentCourses).ThenInclude(sc => sc.Student).ToList();

                foreach (var c in courses)
                {
                    Console.WriteLine($"\n Course: {c.Name}");

                    var students = c.StudentCourses.Select(sc => sc.Student).ToList();
                    foreach (Student s in students)
                        Console.WriteLine($"{s.FName} {s.LName}");
                }
            } 
        }
    }
}
