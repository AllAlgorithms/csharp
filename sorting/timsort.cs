using System;
namespace Algorithms
{
    /// <summary>
    /// This is a C# port of the timsort algorithm
    /// described at https://www.geeksforgeeks.org/timsort/
    /// This is merely a demonstration of TimSort and not an optimised
    /// implementation that should be used in production environments.
    /// </summary>
    public class timsort
    {
        private const int RUN = 32;

        // TimSort uses a combination of InsertionSort and MergeSort
        public static void TimSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i += RUN)
            {
                InsertionSort(array, i, Math.Min((i + 31), (n - 1)));
            }

            for (int size = RUN; size < n; size = 2 * size)
            {
                for (int left = 0; left < n; left += 2 * size)
                {
                    int mid = left + size - 1;
                    int right = Math.Min((left + 2 * size - 1), (n - 1));

                    MergeSort(array, left, mid, right);
                }
            }
        }

        // Insertion Sort Implementation
        private static void InsertionSort(int[] array, int left, int right)
        {
            for (int i = left + 1; i <= right; i++)
            {
                int temp = array[i];
                int j = i - 1;
                while (array[j] > temp && j >= left)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
        }

        // Merge sort implementation
        private static void MergeSort(int[] array, int l, int m, int r)
        {
            int len1 = m - l + 1, len2 = r - m;

            int[] left = new int[len1], right = new int[len2];

            int i = 0;

            for (i = 0; i < len1; i++)
            {
                left[i] = array[l + i];
            }

            for (i = 0; i < len2; i++)
            {
                right[i] = array[m + 1 + i];
            }

            i = 0;
            int j = 0;
            int k = l;

            while (i < len1 && j < len2)
            {
                if (left[i] <= right[j])
                {
                    array[k] = left[i];
                    i++;
                }
                else
                {
                    array[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < len1)
            {
                array[k] = left[i];
                k++;
                i++;
            }

            while (j < len2)
            {
                array[k] = right[j];
                k++;
                j++;
            }
        }
    }
}
