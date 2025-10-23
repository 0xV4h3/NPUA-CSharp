using System;
using System.Collections.Generic;

namespace Laborator10_1
{
    public class UniqueWordsDemo
    {
        public static void Run()
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            var set = new HashSet<string>(text.Split(new[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries));
            Console.WriteLine($"Unique words count: {set.Count}");
            foreach (var w in set)
                Console.WriteLine(w);
        }
    }
}