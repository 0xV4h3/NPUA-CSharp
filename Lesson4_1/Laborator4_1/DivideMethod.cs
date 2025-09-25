using System;

namespace Laborator4_1
{
    public class DivideMethod
    {
        static bool Divide(int a, int b, out int result)
        {
            if (b == 0)
            {
                result = 0;
                return false;
            }
            result = a / b;
            return true;
        }

        public static void Run()
        {
            Console.Write("Enter first integer: ");
            int a = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter second integer: ");
            int b = int.Parse(Console.ReadLine() ?? "0");

            if (Divide(a, b, out int r))
                Console.WriteLine($"{a} / {b} = {r}");
            else
                Console.WriteLine("Division by zero");
        }
    }
}
