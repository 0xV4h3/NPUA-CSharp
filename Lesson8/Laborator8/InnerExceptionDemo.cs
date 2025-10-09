using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator8
{
    public class InnerExceptionDemo
    {
        public static void Run()
        {
            try
            {
                try
                {
                    File.ReadAllText("nofile.txt");
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Loading failed", ex);
                }
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Inner exception: {ex.InnerException?.GetType().Name}: {ex.InnerException?.Message}");
            }
        }
    }
}
