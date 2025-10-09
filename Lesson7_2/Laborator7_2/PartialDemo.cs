using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator7_2
{
    public class PartialDemo
    {
        public static void Run()
        {
            var p = new Person("Vahe") { Age = 21 };
            Console.WriteLine(p.Info());
        }
    }
}
