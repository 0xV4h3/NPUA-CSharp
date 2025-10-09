using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator9
{
    public class FooBar : IFoo, IBar
    {
        void IFoo.Do() => Console.WriteLine("Foo Do");
        void IBar.Do() => Console.WriteLine("Bar Do");
    }
}
