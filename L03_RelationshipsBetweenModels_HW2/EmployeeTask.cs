using System;
using System.Collections.Generic;
using System.Text;

namespace L03_RelationshipsBetweenModels_HW2
{
    public class EmployeeTask
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int TaskId { get; set; }
        public Task Task { get; set; }
    }
}
