using System;
using System.Collections.Generic;
using System.Linq;

namespace Laborator11
{
    public class NameFilterDemo
    {
        public static void Run()
        {
            var names = new List<string> { "Anna", "Armen", "Mariam", "Karen", "Anahit", "Liana" };
            var aNames = names.Where(n => n.StartsWith("A"));

            Console.WriteLine("Names starting with 'A':");
            foreach (var name in aNames)
                Console.WriteLine(name);
        }
    }
}