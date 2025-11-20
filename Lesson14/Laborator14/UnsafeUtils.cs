using System;

namespace Laborator14
{
    public static class UnsafeUtils
    {
        public static void ReverseManagedArray(int[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            unsafe
            {
                fixed (int* p = array)
                {
                    ReverseArray(p, array.Length);
                }
            }
        }

        public static unsafe void ReverseArray(int* arr, int length)
        {
            if (arr == null) throw new ArgumentNullException(nameof(arr));
            int i = 0, j = length - 1;
            while (i < j)
            {
                int tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
                i++; j--;
            }
        }
    }
}