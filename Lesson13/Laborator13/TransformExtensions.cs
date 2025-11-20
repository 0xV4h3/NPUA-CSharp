using System;
using System.Collections.Generic;

namespace Laborator13
{
    public static class TransformExtensions
    {
        public static IEnumerable<T> Transform<T>(IEnumerable<T> source, Func<T, T> map)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (map == null) throw new ArgumentNullException(nameof(map));

            foreach (var item in source)
                yield return map(item);
        }

        public static void Run()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Squares (lambda):");
            foreach (var n in Transform(numbers, x => x * x))
                Console.WriteLine(n);

            var words = new[] { "hello", "world" };
            Console.WriteLine("\nUppercase (method group):");
            foreach (var w in Transform(words, ToUpperInvariant))
                Console.WriteLine(w);
        }

        private static string ToUpperInvariant(string s) => s.ToUpperInvariant();
    }
}