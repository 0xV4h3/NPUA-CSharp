using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator10_1
{
    public class StudentListDemo
    {
        public static void Run()
        {
            var students = new List<Student>
            {
                new Student("Anna", 85),
                new Student("Karen", 78),
                new Student("Liana", 92),
                new Student("Armen", 80)
            };

            Console.WriteLine("Students with Grade > 80:");
            foreach (var s in students)
                if (s.Grade > 80)
                    Console.WriteLine(s);
        }
    }
}
