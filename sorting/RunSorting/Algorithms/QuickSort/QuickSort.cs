using System;

namespace AllAlgorithms.Csharp.Sorting.RunSorting.Algorithms.QuickSort
{
    public class QuickSort
    {
        public int[] Sort(int[] dataToSort)
        {
            Sort(dataToSort, 0, dataToSort.Length - 1);

            return dataToSort;
        }

        private static void Sort(int[] values, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(values, low, high);

                Sort(values, low, pi - 1);
                Sort(values, pi + 1, high);
            }
        }

        private static int Partition(int[] values, int low, int high)
        {
            int pivot = values[high];

            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (values[j] <= pivot)
                {
                    i++;
                    int temp = values[i];
                    values[i] = values[j];
                    values[j] = temp;
                }
            }
            int swap = values[i + 1];
            values[i + 1] = values[high];
            values[high] = swap;
            return (i + 1);
        }
    }
}
