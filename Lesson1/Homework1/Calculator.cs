using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class Calculator
    {
        public static string[] supportedOps = ["+", "-", "*", "/"];
        public static bool Calculate(double operand1, double operand2, string operation, out double result)
        {
            switch (operation)
            {
                case "+":
                    result = operand1 + operand2;
                    return true;
                case "-":
                    result = operand1 - operand2;
                    return true;
                case "*":
                    result = operand1 * operand2;
                    return true;
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Division by zero");
                        result = 0;
                    }
                    else
                    {
                        result = operand1 / operand2;
                        return true;
                    }
                    break;
                default:
                    Console.WriteLine($"{operation} is not supported");
                    result = 0;
                    break;
            }
            return false;
        }
        public static void Run()
        {
            Console.Write("Enter expression [a operation b]: ");
            string expression = Console.ReadLine();
            string[] arguments = expression.Split(' ');

            if (arguments.Length == 3)
            {
                bool success1 = double.TryParse(arguments[0], out double operand1);
                string operation = arguments[1];
                bool success2 = supportedOps.Contains(operation);
                bool success3 = double.TryParse(arguments[2], out double operand2);

                if (success1 && success2 && success3)
                {
                    if (Calculate(operand1, operand2, operation, out double result))
                        Console.WriteLine($"{operand1} {operation} {operand2} = {result}");
                    else
                        Console.WriteLine("Something went wrong");
                }
                else
                    Console.WriteLine("Something went wrong");
            }
            else
            {
                Console.WriteLine("Invalid input. Please provide expression in this form [a operation b].");
            }
        }
    }
}
