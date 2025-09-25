using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public int Speed { get; private set; }

        public Car(string model, int year)
        {
            if (year < 1900)
                throw new ArgumentException("Year can’t be less than 1900");
            Model = model;
            Year = year;
            Speed = 0;
        }

        public void Accelerate(int value = 10)
        {
            Speed += value;
            Console.WriteLine($"{Model} accelerated to {Speed} km/h");
        }

        public void Brake(int value = 10)
        {
            Speed = Math.Max(0, Speed - value);
            Console.WriteLine($"{Model} slowed down to {Speed} km/h");
        }

        public override string ToString()
        {
            return $"{Model} ({Year}), Speed: {Speed} km/h";
        }
    }
}
