using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator9
{
    public class CustomSortDemo
    {
        public static void Run()
        {
            var students = new List<Student>
            {
                new Student("Anna", 91),
                new Student("Karen", 85),
                new Student("Liana", 95)
            };

            students.Sort();
            Console.WriteLine("Sorted by grade:");
            students.ForEach(s => Console.WriteLine(s));

            students.Sort(new SortByName());
            Console.WriteLine("Sorted by name:");
            students.ForEach(s => Console.WriteLine(s));
        }
    }
}
