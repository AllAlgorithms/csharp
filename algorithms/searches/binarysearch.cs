using System;

class BS
{
        static int BinarySearch(int[] data, int key)
        {
            int min = 0;
            int N = data.Length;
            int max = N - 1;
            do
            {
                int mid = (min + max) / 2;
                if (key > data[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
                if (data[mid] == key)
                    return mid;
            } while (min <= max);

            return -1;
        }

        public static void Main()
        {
            int[] values = { 1, 6, 12, 18, 36, 71 };
            int search = 36;
            int index = BinarySearch(values, search);
            Console.WriteLine((index > 0) ? $"Item {search} found at position {index}" : $"Item {search} not found");

            search = 3;
            index = BinarySearch(values, search);
            Console.WriteLine((index > 0) ? $"Item {search} found at position {index}" : $"Item {search} not found");
            Console.ReadKey();
        }
}
