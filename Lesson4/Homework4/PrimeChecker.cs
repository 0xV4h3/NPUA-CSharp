using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class PrimeChecker
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Run()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine() ?? "1");
            if (IsPrime(num))
                Console.WriteLine($"{num} is prime number");
            else
                Console.WriteLine($"{num} is not prime number");
        }
    }
}
