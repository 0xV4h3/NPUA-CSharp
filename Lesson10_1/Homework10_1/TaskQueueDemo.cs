using System;
using System.Collections.Generic;

namespace Homework10_1
{
    public class TaskQueueDemo
    {
        public static void Run()
        {
            var queue = new Queue<string>();
            while (true)
            {
                Console.WriteLine("Enter task (or 'do'/'exit'):");
                string input = Console.ReadLine();
                if (input == "exit") break;
                if (input == "do")
                {
                    if (queue.Count > 0)
                        Console.WriteLine($"Task done: {queue.Dequeue()}");
                    else
                        Console.WriteLine("No tasks to do.");
                }
                else
                {
                    queue.Enqueue(input);
                    Console.WriteLine($"Task added: {input}");
                }
            }
        }
    }
}