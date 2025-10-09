using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator7_2
{
    public partial class Person
    {
        public int Age { get; set; }
        public string Info() => $"{Name}, Age: {Age}";
    }
}
