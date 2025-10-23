using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public class UndoStackDemo
    {
        public static void Run()
        {
            Stack undoStack = new Stack();
            Console.WriteLine("Enter text commands (type 'undo' to revert last, 'exit' to quit):");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exit") break;
                if (input == "undo")
                {
                    if (undoStack.Count > 0)
                        Console.WriteLine($"Undo command: {undoStack.Pop()}");
                    else
                        Console.WriteLine("Nothing to undo.");
                }
                else
                {
                    undoStack.Push(input);
                    Console.WriteLine($"Command '{input}' added.");
                }
            }
        }
    }
}
