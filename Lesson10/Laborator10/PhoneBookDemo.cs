using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator10
{
    public class PhoneBookDemo
    {
        public static void Run()
        {
            Hashtable phoneBook = new Hashtable
            {
                ["Anna"] = "099-11-22-33",
                ["Armen"] = "093-44-55-66",
                ["Liana"] = "097-77-88-99"
            };

            Console.WriteLine("Enter name to search for phone (or 'exit'):");
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "exit") break;
                if (phoneBook.ContainsKey(name))
                    Console.WriteLine($"{name}: {phoneBook[name]}");
                else
                    Console.WriteLine("Not found.");
            }
        }
    }
}
