using System;

namespace AllAlgorithms.Csharp.Sorting.RunSorting.Algorithms.SelectionSort
{
    public class SelectionSort
    {
        public int[] Sort(int[] dataToSort)
        {
            for (int i = 0; i < dataToSort.Length; ++i)
            {
                int minIndex = i;
                for (int j = i + 1; j < dataToSort.Length; ++j)
                {
                    if (dataToSort[j] < dataToSort[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = dataToSort[i];
                dataToSort[i] = dataToSort[minIndex];
                dataToSort[minIndex] = temp;
            }

            return dataToSort;
        }
    }
}
