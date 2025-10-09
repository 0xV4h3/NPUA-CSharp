using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator7_2
{
    public class ContainmentInheritanceDemo
    {
        public static void Run()
        {
            Console.WriteLine("Containment (HAS-A):");
            var car = new Car();
            car.Drive();

            Console.WriteLine("Inheritance (IS-A):");
            Animal a = new Dog();
            a.Speak();
        }
    }
}
