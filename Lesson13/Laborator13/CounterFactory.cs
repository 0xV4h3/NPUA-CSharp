using System;

namespace Laborator13
{
    public static class CounterFactory
    {
        public static Action MakeCounter(int start)
        {
            int value = start;
            return () =>
            {
                value++;
                Console.WriteLine($"Counter (start={start}): {value}");
            };
        }

        public static void Run()
        {
            var c1 = MakeCounter(0);
            var c2 = MakeCounter(100);

            Console.WriteLine("Invoking counters:");
            c1();
            c1();
            c2();
            c1();
            c2();
        }
    }
}