using System;

namespace AllAlgorithms.Csharp.Sorting.RunSorting.Algorithms.MergeSort
{
    public class MergeSort
    {
        public int[] Sort(int[] dataToSort)
        {
            var start = 0;
            var end = dataToSort.Length - 1;

            Sort(dataToSort, start, end);

            return dataToSort;
        }

        private static void Sort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;        // divide the current array in 2 subarrays.
                Sort(arr, start, mid);        // sort the first part of array.
                Sort(arr, mid + 1, end);      // sort the second part of array.

                // merge the subarrays by comparing elements in them.
                Merge(arr, start, mid, end);
            }
        }

        private static void Merge(int[] arr, int start, int mid, int end)
        {
            int p = start, q = mid + 1;

            int[] tempArr = new int[end - start + 1];
            int k = 0;

            for (int i = start; i <= end; i++)
            {
                if (p > mid)					 //checks if first part comes to an end or not .
                    tempArr[k++] = arr[q++];

                else if (q > end)				//checks if second part comes to an end or not
                    tempArr[k++] = arr[p++];

                else if (arr[p] < arr[q])		//compare elements from both parts.
                    tempArr[k++] = arr[p++];

                else
                    tempArr[k++] = arr[q++];
            }
            for (int j = 0; j < k; j++)
            {
                //Now the original array has elements in sorted manner including both parts.
                arr[start++] = tempArr[j];
            }
        }
    }
}
