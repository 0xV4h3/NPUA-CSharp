using System;
using System.ComponentModel.Design;

namespace Homework7
{
    public class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
        {
            new Manager("Anna", 1500),
            new Developer("Karen", 1200),
            new Designer("Liana", 1100)
        };

            Console.WriteLine("Employees working:");
            foreach (var emp in employees)
            {
                emp.Work();
            }

            var appliances = new List<Appliance>
        {
            new TV("Samsung"),
            new WashingMachine("LG")
        };

            Console.WriteLine("\nAppliances:");
            foreach (var app in appliances)
            {
                app.TurnOn();
                app.TurnOff();
            }

            var payables = new List<IPayable>
        {
            new Manager("Anna", 1500),
            new Developer("Karen", 1200),
            new Designer("Liana", 1100),
            new Freelancer("Aram", 900)
        };

            Console.WriteLine("\nPaySalary:");
            foreach (var p in payables)
            {
                p.PaySalary();
            }
        }
    }
}
