using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator9
{
    public class PrimeDemo
    {
        public static void Run()
        {
            Console.WriteLine("Primes up to 20:");
            foreach (var p in PrimeGenerator.GetPrimes(20))
                Console.Write($"{p} ");
            Console.WriteLine();
        }
    }
}
