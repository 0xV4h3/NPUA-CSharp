using System;

namespace Laborator13
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("=== Notifier Demo ===");
            NotifierDemo.Run();

            Console.WriteLine("\n=== TemperatureSensor Demo ===");
            TemperatureSensorDemo.Run();

            Console.WriteLine("\n=== CounterFactory (Closures) Demo ===");
            CounterFactory.Run();

            Console.WriteLine("\n=== Transform (Func/Method Group) Demo ===");
            TransformExtensions.Run();

            Console.WriteLine("\nAll demos finished.");
        }
    }
}