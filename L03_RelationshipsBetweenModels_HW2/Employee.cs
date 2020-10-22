using System;
using System.Collections.Generic;
using System.Text;

namespace L03_RelationshipsBetweenModels_HW2
{
    public class Employee
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        //public ICollection<Task> Tasks { get; set; }
        public List<EmployeeTask> EmployeeTasks { get; set; }

        public Employee()
        {
            EmployeeTasks = new List<EmployeeTask>();
        }
    }
}
