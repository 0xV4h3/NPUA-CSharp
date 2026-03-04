using System;
using System.Threading.Tasks;

namespace Homework5
{
    public class DelayDemo
    {
        public static async Task Run()
        {
            Console.WriteLine("--- Delay demo ---");
            Console.WriteLine("A");
            Task delay = Task.Delay(1000);
            Console.WriteLine("B");
            await delay;
            Console.WriteLine("C");
        }
    }
}