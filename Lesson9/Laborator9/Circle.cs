using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator9
{
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public Circle(double radius) => Radius = radius;
        public double GetArea() => Math.PI * Radius * Radius;
    }
}
