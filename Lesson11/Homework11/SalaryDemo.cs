using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework11
{
    public class SalaryDemo
    {
        public static void Run()
        {
            var employees = new List<Employee>
            {
                new Employee("Anna", 700000),
                new Employee("Armen", 450000),
                new Employee("Karen", 510000),
                new Employee("Liana", 300000)
            };

            var rich = employees.Where(e => e.Salary > 500000);
            Console.WriteLine("Employees with salary > 500000:");
            foreach (var e in rich)
                Console.WriteLine($"{e.Name}: {e.Salary}");

            var avg = employees.Select(e => e.Salary).Average();
            Console.WriteLine($"Average salary: {avg:0.00}");
        }
    }
}