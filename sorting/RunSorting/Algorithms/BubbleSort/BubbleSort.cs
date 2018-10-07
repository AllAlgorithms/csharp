using System;

namespace AllAlgorithms.Csharp.Sorting.RunSorting.Algorithms.BubbleSort
{
    public class BubbleSort
    {
        public int[] Sort(int[] dataToSort)
        {
            int n = dataToSort.Length;

            for (int i = 0; i < n - 1; i++)
            { 
                for (int j = 0; j < n - i - 1; j++)
                { 
                    if (dataToSort[j] > dataToSort[j + 1])
                    {
                        // swap temp and dataToSort[i]
                        int temp = dataToSort[j];
                        dataToSort[j] = dataToSort[j + 1];
                        dataToSort[j + 1] = temp;
                    }
                }
            }

            return dataToSort;
        }
    }
}
