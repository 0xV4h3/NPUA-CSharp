using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1
{
    public class Task2
    {
        public static void Run()
        {
            Console.Write("Your name: ");
            string name = Console.ReadLine();
            Console.Write("Your age: ");
            int age = int.Parse(Console.ReadLine() ?? "1");
            Console.WriteLine($"Hello, {name}, you are {age} years old");
        }
    }
}
