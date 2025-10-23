using System;
using System.Collections;

namespace Laborator10
{
    public class DescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((int)y).CompareTo((int)x);
        }
    }
    public class ArrayListSortDemo
    {
        public static void Run()
        {
            var numbers = new ArrayList { 1, 2, 3, 4, 5 };
            numbers.Sort(new DescComparer());

            foreach (var num in numbers)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
