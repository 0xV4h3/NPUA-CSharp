using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator7_3
{
    public class MoneyToStringDemo
    {
        public static void Run()
        {
            var m = new Money(1234.56m, "USD");
            Console.WriteLine(m.ToString());
            Console.WriteLine(m.ToString("F", null));
            Console.WriteLine(m.ToString("S", null));
            Console.WriteLine(m.ToString("F", CultureInfo.GetCultureInfo("en-US")));
            Console.WriteLine(m.ToString("F", CultureInfo.GetCultureInfo("ru-RU")));
        }
    }
}
