using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework11
{
    public class GroupByGradeDemo
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

            var groups = students.GroupBy(s => s.Grade);
            foreach (var g in groups)
                Console.WriteLine($"Grade {g.Key}: {g.Count()} student(s)");
        }
    }
}