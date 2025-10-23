using System;
using System.Collections;

namespace Laborator10
{
    public class QueueSimulationDemo
    {
        public static void Run()
        {
            Queue queue = new Queue();
            while (true)
            {
                Console.WriteLine("Enter customer name (or 'serve'/'exit'):");
                string input = Console.ReadLine();
                if (input == "exit") break;
                if (input == "serve")
                {
                    if (queue.Count > 0)
                        Console.WriteLine($"Served: {queue.Dequeue()}");
                    else
                        Console.WriteLine("Queue is empty.");
                }
                else
                {
                    queue.Enqueue(input);
                    Console.WriteLine($"Added: {input}");
                }
            }
        }
    }
}
