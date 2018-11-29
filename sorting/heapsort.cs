using System;

class GFG {
    static void heapSort (int[] arr) {
        heapSize = arr.Length - 1;
        for (int i = heapSize / 2; i >= 0; i--) {
            Heapify (arr, i);
        }
        for (int i = arr.Length - 1; i >= 0; i--) {
            Swap (arr, 0, i);
            heapSize--;
            Heapify (arr, 0);
        }

        void Swap (int[] arr, int x, int y) //function to swap elements
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        void Heapify (int[] arr, int index) {
            int left = 2 * index;
            int right = 2 * index + 1;
            int largest = index;

            if (left <= heapSize && arr[left] > arr[index]) {
                largest = left;
            }

            if (right <= heapSize && arr[right] > arr[largest]) {
                largest = right;
            }

            if (largest != index) {
                Swap (arr, index, largest);
                Heapify (arr, largest);
            }
        }
    }

    /* Prints the array */
    static void printArray (int[] arr) {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write (arr[i] + " ");
        Console.WriteLine ();
    }

    // Driver method
    public static void Main () {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        heapSort (arr);
        Console.WriteLine ("Sorted array");
        printArray (arr);
    }

}
