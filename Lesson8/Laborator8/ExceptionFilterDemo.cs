using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator8
{
    public class ExceptionFilterDemo
    {
        public static void Run()
        {
            try
            {
                throw new Exception("DB connection failed");
            }
            catch (Exception ex) when (ex.Message.Contains("DB"))
            {
                Console.WriteLine("Database problem detected.");
            }
        }
    }
}
