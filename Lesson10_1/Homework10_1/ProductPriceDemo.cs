using System;
using System.Collections.Generic;

namespace Homework10_1
{
    public class ProductPriceDemo
    {
        public static void Run()
        {
            var products = new Dictionary<string, double>
            {
                ["apple"] = 120.5,
                ["banana"] = 90.0,
                ["orange"] = 150.0
            };

            Console.WriteLine("Enter product name to search price (or 'exit'):");
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "exit") break;
                if (products.TryGetValue(name, out var price))
                    Console.WriteLine($"{name}: {price} dram");
                else
                    Console.WriteLine("Not found.");
            }
        }
    }
}