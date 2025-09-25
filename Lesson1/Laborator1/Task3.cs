using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1
{
    public class Task3
    {
        public static void Run()
        {
            Console.Write("Enter first additive: ");
            int additive1 = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter second additive: ");
            int additive2 = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Sum: {additive1 + additive2}");
        }
    }
}
