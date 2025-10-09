using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator7_3
{
    public class CloneDemo
    {
        public static void Run()
        {
            var n1 = new Node { Value = 1, Next = new Node { Value = 2 } };
            var shallow = n1.Shallow();
            var deep = n1.Deep();

            shallow.Next!.Value = 99;
            Console.WriteLine($"Original n1.Next.Value: {n1.Next!.Value}");

            deep.Next!.Value = 123;
            Console.WriteLine($"Original n1.Next.Value after deep: {n1.Next!.Value}");
        }
    }
}
