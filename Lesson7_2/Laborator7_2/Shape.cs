using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator7_2
{
    public abstract class Shape { }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double r) { Radius = r; }
    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double w, double h) { Width = w; Height = h; }
    }
}
