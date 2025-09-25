using System;
using System.Linq;

namespace Laborator4_1
{
    public class MinMaxTuple
    {
        static (int min, int max) MinMax(int[] nums)
        {
            return (nums.Min(), nums.Max());
        }

        public static void Run()
        {
            int[] arr = { 5, 1, 9, 3, 7 };
            var (min, max) = MinMax(arr);
            Console.WriteLine($"Min = {min}, Max = {max}");
        }
    }
}
