using System;

namespace csharp.sorting
{
    class Program
    {

        static void shellSort(int[] array)
        {
            int i, j, inc, temp;
            var array_size = array.Length;
            inc = 3;

            while (inc > 0)
            {
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = array[i];
                    while ((j >= inc) && (array[j - inc] > temp))
                    {
                        array[j] = array[j - inc];
                        j = j - inc;
                    }
                    array[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
        }
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public static void Main()
        {
            int[] arr = { 25, 17, 49, 1, 195, 58 };
            heapSort(arr);
            Console.WriteLine("Sorted array");
            printArray(arr);
        }

    }
}