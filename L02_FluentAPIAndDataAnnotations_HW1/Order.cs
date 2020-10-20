using System;
using System.Collections.Generic;
using System.Text;

namespace L02_FluentAPIAndDataAnnotations_HW1
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
    }
}
