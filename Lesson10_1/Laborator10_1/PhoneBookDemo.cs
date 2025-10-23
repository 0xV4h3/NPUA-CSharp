using System;
using System.Collections.Generic;

namespace Laborator10_1
{
    public class PhoneBookDemo
    {
        public static void Run()
        {
            var phoneBook = new Dictionary<string, string>
            {
                ["Anna"] = "099-11-22-33",
                ["Armen"] = "093-44-55-66",
                ["Mariam"] = "095-22-11-00"
            };

            Console.WriteLine("Enter name to search phone (or 'exit'):");
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "exit") break;
                if (phoneBook.TryGetValue(name, out var number))
                    Console.WriteLine($"{name}: {number}");
                else
                    Console.WriteLine("Not found");
            }
        }
    }
}