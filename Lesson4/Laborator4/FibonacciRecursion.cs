using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator4
{
    public class FibonacciRecursion
    {
        static int Fibonacci(int number)
        {
            var cache = new Dictionary<int, int>();

            int FibInternal(int n)
            {
                if (n <= 1) return n;
                if (cache.ContainsKey(n)) return cache[n];

                int value = FibInternal(n - 1) + FibInternal(n - 2);
                cache[n] = value;
                return value;
            }

            return FibInternal(number);
        }

        public static void Run()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine() ?? "1");
            Console.WriteLine(Fibonacci(num));
        }
    }
}
