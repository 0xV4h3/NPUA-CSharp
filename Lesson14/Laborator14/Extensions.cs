using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laborator14
{
    public static class Extensions
    {
        public static bool IsEven(this int value) => (value & 1) == 0;

        public static int WordCount(this string? s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0;
            return s!.Split((char[])null, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static void Shuffle<T>(this IList<T> list, Random? rng = null)
        {
            if (list == null) throw new ArgumentNullException(nameof(list));
            rng ??= new Random();
            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                (list[i], list[j]) = (list[j], list[i]);
            }
        }

        public static string ToCsvString(this IEnumerable<Student> students, bool includeHeader = true)
        {
            var sb = new StringBuilder();
            if (includeHeader) sb.AppendLine("Name,Age");
            foreach (var s in students)
            {
                var name = s.Name.Contains(',') ? $"\"{s.Name.Replace("\"", "\"\"")}\"" : s.Name;
                sb.AppendLine($"{name},{s.Age}");
            }
            return sb.ToString();
        }
    }
}