using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator8
{
    public class CustomExceptionDemo
    {
        public static void CheckGrade(int grade)
        {
            if (grade < 0 || grade > 100)
                throw new InvalidGradeException($"Grade {grade} is invalid. Must be 0..100.");
            Console.WriteLine($"Grade {grade} is valid.");
        }

        public static void Run()
        {
            int[] grades = { 85, 110, -5, 75 };
            foreach (var g in grades)
            {
                try
                {
                    CheckGrade(g);
                }
                catch (InvalidGradeException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
