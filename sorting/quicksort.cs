namespace Algorithms
{
    class quicksort
    {
        public static void quickSort(int[] values)
        {
            quickSort(values, 0, values.Length - 1);
        }

        private static void quickSort(int[] values, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(values, low, high);

                quickSort(values, low, pi - 1); 
                quickSort(values, pi + 1, high); 
            }
        }

        public static int partition(int[] values, int low, int high)
        {
            int pivot = values[high];

            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (values[j] <= pivot)
                {
                    i++;
                    int temp = values[i];
                    values[i] = values[j];
                    values[j] = temp;
                }
            }
            int swap = values[i + 1];
            values[i + 1] = values[high];
            values[high] = swap;
            return (i + 1);
        }
    }
}
