using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public class WashingMachine : Appliance
    {
        public WashingMachine(string name) : base(name) { }

        public override void TurnOn()
        {
            Console.WriteLine($"{Name} washing machine is turned on.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Name} washing machine is turned off.");
        }
    }
}
