using System;

namespace AllAlgorithms.Csharp.Sorting.RunSorting.Algorithms.BubbleSort
{
    public class BubbleSort
    {
        public int[] Sort(int[] dataToSort)
        {
            int[] arrayToSort = new int[dataToSort.Length];
            Array.Copy(dataToSort, arrayToSort, dataToSort.Length);

            int n = arrayToSort.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arrayToSort[j] > arrayToSort[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arrayToSort[j];
                        arrayToSort[j] = arrayToSort[j + 1];
                        arrayToSort[j + 1] = temp;
                    }

            return arrayToSort;
        }
    }
}
