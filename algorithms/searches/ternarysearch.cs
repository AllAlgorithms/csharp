using System;

public class TS
{
    static int TernarySearch(int[] data, int left, int right, int key)
    {
        if (right >= left)
        {
            int mid1 = left + (right - left) / 3;
            int mid2 = right - (right - left) / 3;

            if (data[mid1] == key)
                return mid1;

            if (data[mid2] == key)
                return mid2;

            if (key < data[mid1])
                return TernarySearch(data, left, mid1 - 1, key);
            else if (key > data[mid2])
                return TernarySearch(data, mid2 + 1, right, key);
            else
                return TernarySearch(data, mid1 + 1, mid2 - 1, key);
        }
        return -1;
    }

    public static void Main()
    {
        int[] values = { 2, 3, 5, 6, 8, 9, 12, 13, 14 };
        int search = 6;
        int index = TernarySearch(values, 0, values.Length - 1, search);
        Console.WriteLine((index > 0) ? $"Item {search} found at position {index}" : $"Item {search} not found");

        search = 10;
        index = TernarySearch(values, 0, values.Length - 1, search);
        Console.WriteLine((index > 0) ? $"Item {search} found at position {index}" : $"Item {search} not found");
        Console.ReadKey();
    }
}
