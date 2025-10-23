using System;
using System.Collections.Generic;
using System.Linq;

namespace Laborator11
{
    public class PriceFilterDemo
    {
        public static void Run()
        {
            var products = new List<Product>
            {
                new Product("Laptop", 2500),
                new Product("Mouse", 500),
                new Product("Keyboard", 800),
                new Product("Monitor", 1200),
                new Product("USB", 300)
            };

            var cheap = products.Where(p => p.Price < 1000);

            Console.WriteLine("Products with price < 1000:");
            foreach (var p in cheap)
                Console.WriteLine($"{p.Name}: {p.Price}");
        }
    }
}