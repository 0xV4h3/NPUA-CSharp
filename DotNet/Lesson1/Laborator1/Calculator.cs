using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator1
{
    public interface ICalculator
    {
        decimal Calc();
    }

    class MyCalculator : ICalculator
    {
        private decimal _value;
        public MyCalculator(decimal value)
        {
            _value = value;
        }
        public decimal Calc() => _value * 2;
    }

    public class CalculatorDemo
    {
        public static void Run()
        {
            var list = new List<ICalculator>();

            for (int i = 0; i < 1000000; i++)
            {
                list.Add(new MyCalculator(i));
            }

            decimal sum = 0;

            foreach (var calculator in list)
            {
                sum += calculator.Calc();
            }

            Console.WriteLine(sum);
        }
    }
}
