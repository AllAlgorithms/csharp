using System;

namespace countingsort
{
    public class CountingSort
    {

        static public void Sort(int[] unsorted)
        {
            int[] sorted = new int[unsorted.Length];

            int min = unsorted[0];
            int max = unsorted[0];

            foreach (int val in unsorted)
            {
                if (val < min) min = val;
                if (val > max) max = val;
            }

            int[] counts = new int[max - min + 1];

            for (int i = 0; i < unsorted.Length; i++)
            {
                counts[unsorted[i] - min] += 1;
            }

            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] += counts[i - 1];
            }

            for (int i = unsorted.Length - 1; i >= 0; i--)
            {
                sorted[counts[unsorted[i] - min]--] = unsorted[i];
            }

            for (int i = 0; i < unsorted.Length; i++) unsorted[i] = sorted[i];
        }

        /* Prints the array */
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        // Driver method
        public static void Main()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            Sort(arr);
            Console.WriteLine("Sorted array");
            printArray(arr);
        }
    }
}
