using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public class ProductPriceDemo
    {
        public static void Run()
        {
            HybridDictionary products = new HybridDictionary();
            products["apple"] = 120;
            products["banana"] = 90;
            products["orange"] = 150;

            Console.WriteLine("Enter product name to search price (or 'exit'):");
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "exit") break;
                if (products.Contains(name))
                    Console.WriteLine($"{name}: {products[name]} dram");
                else
                    Console.WriteLine("Not found.");
            }
        }
    }
}
