using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator7_2
{
    public class Car
    {
        private Engine _engine = new Engine();

        public void Drive()
        {
            _engine.Start();
            Console.WriteLine("Car is driving");
        }
    }
}
