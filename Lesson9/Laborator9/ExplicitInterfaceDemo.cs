using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator9
{
    public class ExplicitInterfaceDemo
    {
        public static void Run()
        {
            var obj = new FooBar();
            ((IFoo)obj).Do();
            ((IBar)obj).Do();
        }
    }
}
