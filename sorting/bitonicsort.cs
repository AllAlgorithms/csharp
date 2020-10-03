namespace Algorithms
{
    /// <summary>
    /// This is a C# port of the bitonicsort algorithm
    /// described at https://www.geeksforgeeks.org/bitonic-sort/
    /// This is merely a demonstration of BitonicSort and not an optimised
    /// implementation that should be used in production environments.
    /// </summary>
    public class bitonicsort
    {
        private static void CompAndSwap(int[] array, int i, int j, int dir)
        {
            if ((dir != 0) == (array[i] > array[j]))
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        private static void BitonicMerge(int[] array, int low, int count, int dir)
        {
            if (count > 1)
            {
                int k = count / 2;
                for (int i = low; i < low + k; i++)
                {
                    CompAndSwap(array, i, i + k, dir);
                }

                BitonicMerge(array, low, k, dir);
                BitonicMerge(array, low + k, k, dir);
            }
        }

        private static void Sort(int[] array, int low, int count, int dir)
        {
            if (count > 1)
            {
                int k = count / 2;

                Sort(array, low, k, 1);

                Sort(array, low + k, k, 0);

                BitonicMerge(array, low, count, dir);
            }
        }

        // Only works when input size is of a power of 2
        public static void BitonicSort(int[] array)
        {
            Sort(array, 0, array.Length, 1);
        }

    }
}
