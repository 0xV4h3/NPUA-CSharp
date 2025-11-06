using System;

namespace Laborator12
{
    public class GarbageCollectorDemo
    {
        class BigObject
        {
            public byte[] Data = new byte[1024 * 100];
        }

        public static void Run()
        {
            var bigObjects = new BigObject[10];
            Console.WriteLine("Creating big objects:");
            for (int i = 0; i < bigObjects.Length; i++)
            {
                bigObjects[i] = new BigObject();
                Console.WriteLine($"Object {i}: Generation = {GC.GetGeneration(bigObjects[i])}");
            }

            for (int i = 0; i < bigObjects.Length; i++)
                bigObjects[i] = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("After GC:");
            Console.WriteLine($"Total Memory: {GC.GetTotalMemory(true) / 1024.0 / 1024:0.00} MB");
        }
    }
}