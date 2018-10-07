using System;

namespace AllAlgorithms.Csharp.Sorting.RunSorting.Algorithms.RadixSort
{
    public class RadixSort
    {
        public int[] Sort(int[] dataToSort)
        {
            int i, j;
            int[] temp = new int[dataToSort.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < dataToSort.Length; ++i)
                {
                    bool move = (dataToSort[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        dataToSort[i - j] = dataToSort[i];
                    else
                        temp[j++] = dataToSort[i];
                }
                Array.Copy(temp, 0, dataToSort, dataToSort.Length - j, j);
            }

            return dataToSort;
        }
    }
}
