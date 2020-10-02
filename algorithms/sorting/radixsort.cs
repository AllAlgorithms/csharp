using System;

namespace Algorithms
{
    class radixsort
    {
        // https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-10.php
        public static void radixSort(int[] values)
        {
            int i, j;
            int[] temp = new int[values.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < values.Length; ++i)
                {
                    bool move = (values[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        values[i - j] = values[i];
                    else
                        temp[j++] = values[i];
                }
                Array.Copy(temp, 0, values, values.Length - j, j);
            }
        }
    }
}
