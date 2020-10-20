using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace L02_FluentAPIAndDataAnnotations_HW2
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
        public Course()
        {
            StudentCourses = new List<StudentCourse>();
        }
    }
}
