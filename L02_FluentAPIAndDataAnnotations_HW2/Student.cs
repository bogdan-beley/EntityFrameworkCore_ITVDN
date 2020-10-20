using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace L02_FluentAPIAndDataAnnotations_HW2
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }

        public Student()
        {
            StudentCourses = new List<StudentCourse>();
        }
    }
}
