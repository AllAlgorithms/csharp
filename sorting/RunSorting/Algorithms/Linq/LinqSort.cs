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
            return dataToSort.OrderBy(o => o).ToArray();
        }

        public int[] GenericSort(int[] dataToSort)
        {
            var comparer = new GenericComparer();
            Array.Sort(dataToSort, comparer);

            return dataToSort;
        }

        public int[] TypedSort(int[] dataToSort)
        {
            var comparer = new TypedComparer();
            Array.Sort(dataToSort, comparer);

            return dataToSort;
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
