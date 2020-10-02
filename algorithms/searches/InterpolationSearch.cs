/* Interpolation Search C# - Created by: Ehsan Mohammadi
   
   Algorithm:
    Step1: In a loop, calculate the value of "middle" using the probe position formula.
    Step2: If it is a match, return the index of the item, and exit.
    Step3: If the item is less than list[middle], calculate the probe position of the left sub-array. Otherwise calculate the same in the right sub-array.
    Step4: Repeat until a match is found or the sub-array reduces to 0.
 */

using System;
using System.Collections.Generic;

namespace InterpolationSearch
{
    class InterpolationSearch
    {
        public static int InterpSearch(List<int> list, int data)
        {
            // Initialize
            int low = 0, high = list.Count - 1, middle;
            int index = -1;

            int denominator;

            if (list[low] <= data && list[high] >= data)
            {
                while (low <= high && index == -1)
                {
                    denominator = list[high] - list[low];
                    if (denominator == 0)
                        middle = low;
                    else
                        middle = low + (int)(((data - list[low])*(high - low))/denominator);

                    if (data == list[middle])
                        index = middle;
                    else if (data < list[middle])
                        high = middle - 1;
                    else
                        low = middle + 1;
                }
            }

            return index;
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int> { 2, 4, 5, 8, 11 };
            int index = InterpSearch(list, 8);

            if(index != -1)
                Console.WriteLine("Item found at index " + index);
            else
                Console.WriteLine("Item not found");

            Console.ReadKey();
        }
    }
}
