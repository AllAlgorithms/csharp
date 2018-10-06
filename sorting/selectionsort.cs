
namespace Algorithms
{
    class selectionsort
    {
        public static void selectionSort(int[] values)
        {
            for(int i = 0; i < values.Length; ++i)
            {
                int minIndex = i;
                for(int j = i + 1; j < values.Length; ++j)
                {
                    if(values[j] < values[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = values[i];
                values[i] = values[minIndex];
                values[minIndex] = temp;
            }
        }
    }
}
