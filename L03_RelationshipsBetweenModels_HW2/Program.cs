using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace L03_RelationshipsBetweenModels_HW2
{
    // Many-to-Many Relationship Model
    class Program
    {
        static void Main(string[] args)
        {
            using (DataContext db = new DataContext())
            {
                Employee emp1 = new Employee() { FName = "David", LName = "Adams" };
                Task t1 = new Task() { Name = "Create a project presentation", Description = "Create a presentation for Demo-project" };

                db.Employees.Add(emp1);
                db.Tasks.Add(t1);
                db.SaveChanges();

                t1.EmployeeTasks.Add(new EmployeeTask { EmployeeId = 1, TaskId = 1 });
                db.SaveChanges();


                var tasks = db.Tasks.Include(t => t.EmployeeTasks).ThenInclude(et => et.Employee).ToList();

                foreach (var task in tasks)
                {
                    foreach (var e in task.EmployeeTasks)
                    {
                        Console.WriteLine($"{task.Id}. Name: {task.Name} Description: {task.Description} Creating: {task.CreatingDate.ToShortDateString()} Employee: {e.Employee.FName} {e.Employee.LName}");
                    }
                }
            }
        }
    }
}
