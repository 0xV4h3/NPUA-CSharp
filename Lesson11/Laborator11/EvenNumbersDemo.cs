using System;
using System.Collections.Generic;
using System.Linq;

namespace Laborator11
{
    public class EvenNumbersDemo
    {
        public static void Run()
        {
            var nums = Enumerable.Range(1, 20).ToList();
            var evens = nums.Where(n => n % 2 == 0);

            Console.WriteLine("Even numbers (1..20):");
            foreach (var n in evens)
                Console.Write($"{n} ");
            Console.WriteLine();
        }
    }
}