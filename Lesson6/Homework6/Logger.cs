using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class Logger
    {
        private static DateTime startTime;
        static Logger()
        {
            startTime = DateTime.Now;
            Console.WriteLine($"Logger started at {startTime}");
        }

        public static void Log(string msg)
        {
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {msg}");
        }
    }
}
