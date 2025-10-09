using System;
using System.IO;

namespace Laborator7_3
{
    public class DisposeDemo
    {
        public static void Run()
        {
            string path = "esenin.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("Contents of esenin.txt:");
                Console.WriteLine(new string('-', 40));
                string text = File.ReadAllText(path);
                Console.WriteLine(text);
                Console.WriteLine(new string('-', 40));
            }
            else
            {
                Console.WriteLine("File esenin.txt not found.");
            }

            using (var user = new SafeFileUser(path))
            {
                Console.WriteLine("Handle opened & will be safely disposed.");
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("GC.Collect() called for demo.");
        }
    }
}