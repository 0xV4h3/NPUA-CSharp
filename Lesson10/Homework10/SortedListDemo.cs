using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public class SortedListDemo
    {
        public static void Run()
        {
            SortedList students = new SortedList();
            students["Anna"] = 91;
            students["Karen"] = 85;
            students["Liana"] = 95;

            Console.WriteLine("Students (sorted by name):");
            foreach (DictionaryEntry entry in students)
                Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}
