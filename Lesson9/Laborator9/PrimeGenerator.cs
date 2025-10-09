using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator9
{
    public class PrimeGenerator
    {
        public static IEnumerable<int> GetPrimes(int max)
        {
            for (int num = 2; num <= max; num++)
            {
                bool isPrime = true;
                for (int d = 2; d * d <= num; d++)
                    if (num % d == 0) { isPrime = false; break; }
                if (isPrime) yield return num;
            }
        }
    }
}
