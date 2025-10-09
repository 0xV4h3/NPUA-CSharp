using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator7_2
{
    public class PatternMatchingDemo
    {
        public static void Run()
        {
            Shape[] shapes = {
                new Circle(5),
                new Circle(15),
                new Rectangle(3, 4),
                null
            };

            foreach (var shape in shapes)
            {
                string desc = shape switch
                {
                    Circle { Radius: > 10 } c => $"Big circle: {c.Radius}",
                    Circle c => $"Circle: {c.Radius}",
                    Rectangle r => $"Rect: {r.Width}x{r.Height}",
                    null => "Null shape",
                    _ => "Unknown shape"
                };
                Console.WriteLine(desc);
            }
        }
    }
}
