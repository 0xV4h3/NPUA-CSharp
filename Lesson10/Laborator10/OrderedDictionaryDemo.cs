using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator10
{
    public class OrderedDictionaryDemo
    {
        public static void Run()
        {
            OrderedDictionary students = new OrderedDictionary();
            students.Add("Anna", 91);
            students.Add("Karen", 85);
            students.Add("Liana", 95);

            Console.WriteLine("All students (in order):");
            foreach (DictionaryEntry entry in students)
                Console.WriteLine($"{entry.Key}: {entry.Value}");

            if (students.Count > 0)
                Console.WriteLine($"First student added: {students.Cast<DictionaryEntry>().First().Key}");
        }
    }
}
