using System;
using System.Threading.Tasks;

namespace Homework5
{
    public class ResultVsAwaitDemo
    {
        public static async Task Run()
        {
            Console.WriteLine("--- Result vs await demo ---");
            Console.WriteLine("Await case:");
            try
            {
                await FaultyAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception with await: " + ex.GetType().Name);
            }
            Console.WriteLine();

            Console.WriteLine("Result/.Wait() case:");
            try
            {
                FaultyAsync().Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception with .Wait(): " + ex.GetType().Name);
                if (ex is AggregateException agg && agg.InnerException != null)
                {
                    Console.WriteLine("Inner exception: " + agg.InnerException.GetType().Name);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Explanation: Await propagates the exception directly; .Wait() wraps it inside an AggregateException.");
        }

        private static async Task FaultyAsync()
        {
            await Task.Delay(200);
            throw new InvalidOperationException("Demo exception");
        }
    }
}