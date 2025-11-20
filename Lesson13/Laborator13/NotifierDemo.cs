using System;
using System.Collections.Generic;
using System.IO;

namespace Laborator13
{
    public delegate void Notifier(string msg);

    public static class NotifierDemo
    {
        private static readonly List<string> MemoryLog = new();

        public static void LogConsole(string msg) => Console.WriteLine($"[Console] {msg}");

        public static void LogFile(string msg)
        {
            File.AppendAllText("notifier_log.txt", $"[File] {msg}{Environment.NewLine}");
        }

        public static void LogMemory(string msg) => MemoryLog.Add($"[Memory] {msg}");

        public static void Run()
        {
            Notifier notifier = LogConsole;
            notifier += LogFile;
            notifier += LogMemory;

            Console.WriteLine("Invoking multicast notifier (all handlers):");
            notifier("First notification");

            notifier -= LogFile;
            Console.WriteLine("\nAfter removing file logger:");
            notifier("Second notification");

            Console.WriteLine("\nInvoking with per-handler error isolation:");
            notifier += ThrowingHandler;
            foreach (Delegate d in notifier.GetInvocationList())
            {
                try
                {
                    ((Notifier)d).Invoke("Per-target call");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Handler {d.Method.Name} threw: {ex.Message}");
                }
            }

            Console.WriteLine("\nMemory log contents:");
            foreach (var item in MemoryLog)
                Console.WriteLine(item);
        }

        private static void ThrowingHandler(string _)
        {
            throw new InvalidOperationException("Simulated handler failure");
        }
    }
}