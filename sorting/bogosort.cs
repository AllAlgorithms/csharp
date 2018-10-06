using System;

namespace bogosort
{
    public class BogoSort
    {

        private static void Swap(int[] arr, int left, int right)
        {
            int leftOrig = arr[left];
            arr[left] = arr[right];
            arr[right] = leftOrig;
        }

        private static bool IsSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1]) return false;
            }
            return true;
        }

        private static void Shuffle(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Random swapper = new Random();

                int swap = swapper.Next(arr.Length);
                Swap(arr, i, swap);
            }
        }

        public static void Sort(int[] arr)
        {
            while (!IsSorted(arr))
            {
                Shuffle(arr);
            }
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
            int[] arr = { 64, 34, 25 };
            Sort(arr);
            Console.WriteLine("Sorted array");
            printArray(arr);
        }
    }
}
