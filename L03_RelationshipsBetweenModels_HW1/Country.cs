using System;
using System.Collections.Generic;
using System.Text;

namespace L03_RelationshipsBetweenModels_HW1
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
