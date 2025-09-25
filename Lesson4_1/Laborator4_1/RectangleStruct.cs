using System;

namespace Laborator4_1
{
    struct Rectangle
    {
        public double Width;
        public double Height;

        public Rectangle(double w, double h)
        {
            Width = w;
            Height = h;
        }

        public double GetArea() => Width * Height;
    }
    public class RectangleStruct
    {
        public static void Run()
        {
            Console.Write("Enter width: ");
            int w = int.Parse(Console.ReadLine() ?? "1");

            Console.Write("Enter height: ");
            int h = int.Parse(Console.ReadLine() ?? "1");

            Rectangle r = new(w, h);
            Console.WriteLine($"Area = {r.GetArea()}");
        }
    }
}
