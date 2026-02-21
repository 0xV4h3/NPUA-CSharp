using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator3
{
    public class FileProcessor
    {
        public static void Run(string[] args)
        {
            if (args.Length == 0)
            {
                ShowHelp();
                return;
            }
            string command = args[0].ToLower();
            switch(command)
            {
                case "count":
                    CountFile(args);
                    break;
                case "clean":
                    CleanFile(args);
                    break;
                case "batch":
                    BatchProcess(args);
                    break;
                default:
                    Console.WriteLine("Unknown command");
                    ShowHelp();
                    break;
            }
        }

        static void CountFile(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Specify file path.");
                return;
            }
            string path = args[1];
            if (!File.Exists(path))
            {
                Console.WriteLine("File not found");
                return;
            }
            string content = File.ReadAllText(path);
            int lines = File.ReadAllLines(path).Length;
            int words = content.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int chars = content.Length;
            Console.WriteLine($"Lines: {lines}");
            Console.WriteLine($"Words: {words}");
            Console.WriteLine($"Chars: {chars}");
        }

        static void CleanFile(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Usage: clean input.txt output.txt");
                return;
            }
            string input = args[1];
            string output = args[2];
            if (!File.Exists(input))
            {
                Console.WriteLine("Input file not found");
                return;
            }
            var cleanedLines = File.ReadAllLines(input)
                .Select(line => line.Trim())
                .Where(line => !string.IsNullOrEmpty(line));
            File.WriteAllLines(output, cleanedLines);
            Console.WriteLine($"File cleaned successfully.");
        }

        static void BatchProcess(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Specify folder path.");
                return;
            }
            string folder = args[1];
            if (!Directory.Exists(folder))
            {
                Console.WriteLine("Folder not found");
                return;
            }
            var files = Directory.GetFiles(folder, "*.txt");
            foreach (var file in files)
            {
                var lines = File.ReadAllLines(file)
                            .Where(line => !string.IsNullOrWhiteSpace(line));
                File.WriteAllLines(file, lines);
                Console.WriteLine($"Processed {Path.GetFileName(file)}");
            }
            Console.WriteLine("Batch processing completed.");
        }

        static void ShowHelp()
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("  count <file>");
            Console.WriteLine("  clean <input> <output>");
            Console.WriteLine("  batch <folder>");
        }
    }
}
