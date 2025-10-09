using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator7_3
{
    public class ProductEqualityDemo
    {
        public static void Run()
        {
            var dict = new Dictionary<ProductCode, Product>
            {
                [new ProductCode("SKU123", "AM")] = new Product("Apple"),
                [new ProductCode("SKU123", "RU")] = new Product("Яблоко"),
                [new ProductCode("SKU123", "AM")] = new Product("Խնձոր")
            };
            foreach (var kv in dict)
                Console.WriteLine($"{kv.Key} → {kv.Value}");
        }
    }
}
