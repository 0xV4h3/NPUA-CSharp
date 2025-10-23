using System;
using System.Collections.Generic;

namespace Homework10_1
{
    public class UniqueEmailDemo
    {
        public static void Run()
        {
            var emails = new HashSet<string>();
            Console.WriteLine("Enter email (or 'exit'):");
            while (true)
            {
                string email = Console.ReadLine();
                if (email == "exit") break;
                if (!emails.Add(email))
                    Console.WriteLine("Duplicate!");
                else
                    Console.WriteLine("Added.");
            }
            Console.WriteLine($"Total unique emails: {emails.Count}");
        }
    }
}