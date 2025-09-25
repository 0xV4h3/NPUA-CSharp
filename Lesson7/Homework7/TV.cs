using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public class TV : Appliance
    {
        public TV(string name) : base(name) { }

        public override void TurnOn()
        {
            Console.WriteLine($"{Name} TV is turned on.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Name} TV is turned off.");
        }
    }
}
