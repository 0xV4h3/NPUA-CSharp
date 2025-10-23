using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public class LengthComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((string)x).Length.CompareTo(((string)y).Length);
        }
    }

    public class LengthComparerDemo
    {
        public static void Run()
        {
            ArrayList list = new ArrayList { "cat", "elephant", "dog", "crocodile", "bee" };
            list.Sort(new LengthComparer());
            Console.WriteLine("Strings sorted by length:");
            foreach (string s in list)
                Console.WriteLine(s);
        }
    }
}
