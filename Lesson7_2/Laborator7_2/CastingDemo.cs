using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator7_2
{
    public class Base { }
    public class Derived : Base
    {
        public void Foo() => Console.WriteLine("Derived Foo");
    }

    public class CastingDemo
    {
        public static void Run()
        {
            Base b = new Derived();
            Derived d1 = (Derived)b;
            d1.Foo();

            Base b2 = new Base();
            Derived d2 = b2 as Derived;
            if (d2 == null)
                Console.WriteLine("Downcast failed: d2 is null");

            if (b is Derived d3)
                d3.Foo();

            object obj = "hello";
            string s = obj as string;
            Console.WriteLine(s);

            obj = 42;
            s = obj as string;
            Console.WriteLine(s == null ? "obj not a string" : s);
        }
    }
}
