using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AllAlgorithms.Csharp.Sorting.RunSorting.Algorithms.Linq
{
    public class Linq
    {
        public int[] OrderBy(int[] dataToSort)
        {
            int[] arrayToSort = new int[dataToSort.Length];
            Array.Copy(dataToSort, arrayToSort, dataToSort.Length);

            return arrayToSort.OrderBy(o => o).ToArray();
        }

        public int[] GenericSort(int[] dataToSort)
        {
            int[] arrayToSort = new int[dataToSort.Length];
            Array.Copy(dataToSort, arrayToSort, dataToSort.Length);

            var comparer = new GenericComparer();
            Array.Sort(arrayToSort, comparer);

            return arrayToSort;
        }

        public int[] TypedSort(int[] dataToSort)
        {
            int[] arrayToSort = new int[dataToSort.Length];
            Array.Copy(dataToSort, arrayToSort, dataToSort.Length);

            var comparer = new TypedComparer();
            Array.Sort(arrayToSort, comparer);

            return arrayToSort;
        }

        private class GenericComparer : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                return ((new CaseInsensitiveComparer()).Compare(y, x));
            }
        }

        private class TypedComparer :IComparer<int>
        {
            public int Compare(int x, int y)
            {
                if (x > y)
                {
                    return 1;
                }
                if (x > y)
                {
                    return -1;
                }

                // The orders are equivalent.
                return 0;
            }
        }
    }
}
