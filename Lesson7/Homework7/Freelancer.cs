using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public class Freelancer : IPayable
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Freelancer(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public void PaySalary()
        {
            Console.WriteLine($"Freelancer {Name} received payment: {Salary}");
        }
    }
}
