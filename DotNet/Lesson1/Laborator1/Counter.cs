using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator1
{
    public struct Counter
    {
        public int Value;
        public void Increment()
        {
            Value++;
        }
    }

    public class CounterDemo
    {
        public static void IncrementCounter(in Counter counter)
        {
            counter.Increment();
        }
        public static void Run()
        {
            Counter c = new Counter { Value = 5};
            IncrementCounter(c);
            Console.WriteLine(c.Value);

        }
    }
}