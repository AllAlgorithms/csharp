using System;

namespace AllAlgorithms.Csharp.Sorting.RunSorting.Algorithms.BogoSort
{
    public class BogoSort
    {
        public int[] Sort(int[] dataToSort)
        {
            while (!IsSorted(dataToSort))
            {
                Shuffle(dataToSort);
            }

            return dataToSort;
        }

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
    }
}
