using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator9
{
    public class InterfaceBasicDemo
    {
        public static void Run()
        {
            IShape[] shapes = {
                new Circle(3),
                new Rectangle(4, 5)
            };
            foreach (var s in shapes)
                Console.WriteLine($"{s.GetType().Name} area: {s.GetArea():0.00}");
        }
    }
}
