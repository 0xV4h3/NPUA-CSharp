using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public abstract class Appliance
    {
        public string Name { get; set; }

        public Appliance(string name)
        {
            Name = name;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();
    }
}
