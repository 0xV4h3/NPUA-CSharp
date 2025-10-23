using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework11
{
    public class IntStatsDemo
    {
        public static void Run()
        {
            var nums = new List<int> { 12, 45, 63, 3, 99, 15, 7 };
            Console.WriteLine($"Max: {nums.Max()}");
            Console.WriteLine($"Min: {nums.Min()}");
            Console.WriteLine($"Sum: {nums.Sum()}");
            Console.WriteLine($"Average: {nums.Average():0.00}");
        }
    }
}