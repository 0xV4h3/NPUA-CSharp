using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework11
{
    public class LongWordsDemo
    {
        public static void Run()
        {
            var words = new List<string> { "apple", "banana", "cucumber", "fig", "grapefruit", "pear", "watermelon" };
            var filtered = words.Where(w => w.Length > 5);

            Console.WriteLine("Words with length > 5:");
            foreach (var w in filtered)
                Console.WriteLine(w);
        }
    }
}