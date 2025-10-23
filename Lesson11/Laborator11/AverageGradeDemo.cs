using System;
using System.Collections.Generic;
using System.Linq;

namespace Laborator11
{
    public class AverageGradeDemo
    {
        public static void Run()
        {
            var students = new List<Student>
            {
                new Student("Anna", 90),
                new Student("Armen", 75),
                new Student("Mariam", 90),
                new Student("Karen", 80)
            };

            var average = students.Select(s => s.Grade).Average();
            Console.WriteLine($"Average grade: {average:0.00}");
        }
    }
}