namespace Algorithms
{
    class insertionsort
    {
        public static void insertionSort(int[] values)
        {
            int val = 0;

            for(int i = 1; i < values.Length; ++i)
            {
                val = values[i];
                int j;
                for (j = i - 1; j >= 0 && values[j] > val; --j)
                {
                    values[j + 1] = values[j];
                }
                values[j + 1] = val;
            }
        }
    }
}
