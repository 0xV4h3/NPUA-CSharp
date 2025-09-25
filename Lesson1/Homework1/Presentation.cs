using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class Presentation
    {
        public static void Run()
        {
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();

            Console.Write("Enter your surname : ");
            string surname = Console.ReadLine();

            Console.Write("Enter city : ");
            string city = Console.ReadLine();

            Console.WriteLine($"I am {name} {surname}, i live in {city}");
        }
    }
}
