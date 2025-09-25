using System;

namespace Laborator4_1
{
    public class RowSums2DArray
    {
        public static void Run()
        {
            int[,] arr = { { 1, 5, 3 }, { 7, 2, 9 }, { 4, 6, 8 } };
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < cols; j++)
                    sum += arr[i, j];
                Console.WriteLine($"Row {i} sum = {sum}");
            }
        }
    }
}
