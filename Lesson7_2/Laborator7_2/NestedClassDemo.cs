using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator7_2
{
    public class NestedClassDemo
    {
        public static void Run()
        {
            var n = new Outer.Nested();
            n.Print();
        }
    }
}
