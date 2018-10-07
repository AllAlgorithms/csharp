using System;

namespace AllAlgorithms.Csharp.Sorting.RunSorting.Algorithms.CocktailSort
{
    public class CocktailSort
    {
        public int[] Sort(int[] dataToSort)
        {
            int n = dataToSort.Length;
            for (int i = n - 1; i > 0; i--)
            {
                bool swapped = false;

                for (int j = i; j > 0; j--)
                {
                    if (dataToSort[j] < dataToSort[j - 1])
                    {
                        // swap temp and arr[j]
                        int temp = dataToSort[j];
                        dataToSort[j] = dataToSort[j - 1];
                        dataToSort[j - 1] = temp;
                        swapped = true;
                    }
                }

                for (int j = 0; j < i; j++)
                {
                    if (dataToSort[j] > dataToSort[j + 1])
                    {
                        // swap temp and arr[j]
                        int temp = dataToSort[j];
                        dataToSort[j] = dataToSort[j + 1];
                        dataToSort[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }

            return dataToSort;
        }
    }
}
