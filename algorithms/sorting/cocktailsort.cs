using System;

public class C_S
{
    public static void cocktailSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = n - 1; i > 0; i--)
        {
            bool swapped = false;

            for (int j = i; j > 0; j--)
            {
                if (arr[j] < arr[j - 1])
                {
                    // swap temp and arr[j]
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    swapped = true;
                }
            }

            for (int j = 0; j < i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // swap temp and arr[j]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }
    }

    /* Prints the array */
    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    // Driver method
    public static void Main(string[] args)
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        cocktailSort(arr);
        Console.WriteLine("Sorted array");
        printArray(arr);
        Console.ReadKey();
    }
}
