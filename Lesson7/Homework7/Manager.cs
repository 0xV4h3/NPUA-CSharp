using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public class Manager : Employee
    {
        public Manager(string name, decimal salary) : base(name, salary) { }

        public override void Work()
        {
            Console.WriteLine($"{Name} is managing the team.");
        }
    }
}
