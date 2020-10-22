using System;
using System.Collections.Generic;
using System.Text;

namespace L03_RelationshipsBetweenModels_HW1
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
