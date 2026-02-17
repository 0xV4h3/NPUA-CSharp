using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator1
{
    public class ModifyDemo
    {
        static void Modify(object o)
        {
            int y = (int)o;
            y += 5;
            o = y; 
        }
        public static void Run()
        {
            int x = 10;
            object obj = x;
            Modify(obj);
            Console.WriteLine(x);
            Console.WriteLine(obj);
        }
    }
}
