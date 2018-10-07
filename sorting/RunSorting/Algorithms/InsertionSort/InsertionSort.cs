using System;

namespace AllAlgorithms.Csharp.Sorting.RunSorting.Algorithms.InsertionSort
{
    public class InsertionSort
    {
        public int[] Sort(int[] dataToSort)
        {
            int val = 0;

            for (int i = 1; i < dataToSort.Length; ++i)
            {
                val = dataToSort[i];
                int j;
                for (j = i - 1; j >= 0 && dataToSort[j] > val; --j)
                {
                    dataToSort[j + 1] = dataToSort[j];
                }
                dataToSort[j + 1] = val;
            }

            return dataToSort;
        }
    }
}
