using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator10
{
    public class StackUndoDemo
    {
        public static void Run()
        {
            Stack stack = new Stack();
            while (true)
            {
                Console.WriteLine("Enter command (or 'undo'/'exit'):");
                string input = Console.ReadLine();
                if (input == "exit") break;
                if (input == "undo")
                {
                    if (stack.Count > 0)
                        Console.WriteLine($"Undo: {stack.Pop()}");
                    else
                        Console.WriteLine("Nothing to undo.");
                }
                else
                {
                    stack.Push(input);
                    Console.WriteLine($"Command added: {input}");
                }
            }
        }
    }
}
