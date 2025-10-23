using System;
using System.Collections.Generic;

namespace Homework10_1
{
    public class BrowserHistoryDemo
    {
        public static void Run()
        {
            var stack = new Stack<string>();
            while (true)
            {
                Console.WriteLine("Enter page name (or 'undo'/'exit'):");
                string input = Console.ReadLine();
                if (input == "exit") break;
                if (input == "undo")
                {
                    if (stack.Count > 0)
                        Console.WriteLine($"Undo page: {stack.Pop()}");
                    else
                        Console.WriteLine("No pages to undo.");
                }
                else
                {
                    stack.Push(input);
                    Console.WriteLine($"Visited: {input}");
                }
            }
        }
    }
}