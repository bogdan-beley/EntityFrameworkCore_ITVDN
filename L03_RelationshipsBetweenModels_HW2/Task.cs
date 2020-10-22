using System;
using System.Collections.Generic;
using System.Text;

namespace L03_RelationshipsBetweenModels_HW2
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatingDate { get; set; }
        //public ICollection<Employee> Employees { get; set; }
        public List<EmployeeTask> EmployeeTasks { get; set; }
        public Task()
        {
            EmployeeTasks = new List<EmployeeTask>();
        }
    }
}
