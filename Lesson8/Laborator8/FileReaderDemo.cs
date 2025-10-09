using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator8
{
    public class FileReaderDemo
    {
        public static void Run()
        {
            StreamReader? reader = null;
            try
            {
                reader = new StreamReader("asadov.txt");
                Console.WriteLine("Contents of asadov.txt:");
                Console.WriteLine(new string('-', 40));
                Console.WriteLine(reader.ReadToEnd());
                Console.WriteLine(new string('-', 40));
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            finally
            {
                reader?.Dispose();
                Console.WriteLine("Cleanup done.");
            }
        }
    }
}
