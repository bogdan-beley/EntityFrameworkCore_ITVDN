using System;
using System.Collections.Generic;

namespace L01_IntroductionToEFCore_HW2
{
    public partial class Books
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }
}
