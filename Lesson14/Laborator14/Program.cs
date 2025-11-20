using System;
using System.Collections.Generic;
using System.Linq;

namespace Laborator14
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("=== StudentCollection demo (Indexer + Operator + Implicit conversion) ===");

            var groupA = new StudentCollection();
            groupA.Add(new Student("Alice", 20));
            groupA.Add(new Student("Bob", 17));

            var groupB = new StudentCollection();
            groupB.Add(new Student("Charlie, Jr", 22));
            groupB.Add(new Student("Diana", 19));

            Console.WriteLine($"groupA[0] = {groupA[0]}");
            groupA[1] = new Student("Bobby", 18);
            Console.WriteLine($"After replace: groupA[1] = {groupA[1]}");

            var combined = groupA + groupB;
            Console.WriteLine($"Combined count = {combined.Count}");

            List<Student> list = combined;
            Console.WriteLine($"Converted to List<Student> ({list.Count} items)");

            Console.WriteLine("\nCSV output:");
            Console.WriteLine(combined.ToCsvString());

            var overview = from s in combined
                           select new { s.Name, IsAdult = s.Age >= 18 };
            Console.WriteLine("Anonymous projection (Name, IsAdult):");
            foreach (var item in overview)
                Console.WriteLine($"{item.Name} -> IsAdult: {item.IsAdult}");

            Console.WriteLine($"\nIs 42 even? {42.IsEven()}");
            var phrase = "Hello world from C#";
            Console.WriteLine($"Word count: \"{phrase}\" -> {phrase.WordCount()}");

            Console.WriteLine("\nShuffle demo:");
            list.Shuffle();
            foreach (var s in list) Console.WriteLine(s);

            Console.WriteLine("\nUnsafe ReverseArray demo:");
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Before: " + string.Join(", ", arr));
            UnsafeUtils.ReverseManagedArray(arr);
            Console.WriteLine("After:  " + string.Join(", ", arr));

            Console.WriteLine("\nAll demos complete.");
        }
    }
}