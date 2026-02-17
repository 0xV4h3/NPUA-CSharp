using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator1
{
    public class PointDemo
    {
        static void MoveStruct(PointStruct p)
        {
            p.X += 10;
            p.Y += 10;
        }

        static void MoveClass(PointClass p)
        {
            p.X += 10;
            p.Y += 10;
        }
        public static void Run()
        {
            var ps = new PointStruct { X = 5, Y = 5 };
            var pc = new PointClass(5, 5);

            MoveStruct(ps);
            MoveClass(pc);

            Console.WriteLine($"Struct: {ps.X}, {ps.Y}");
            Console.WriteLine($"Class: {pc.X}, {pc.Y}");
        }
    }
}
