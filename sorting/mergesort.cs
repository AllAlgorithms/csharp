using System; 

namespace CsharpAlgo
{
    class Program
    {       
       static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of Array");
            int size = int.Parse(Console.ReadLine());  //Read array size.
            Console.WriteLine("Enter the Array elements");

            string[] usrInput = Console.ReadLine().Split(' '); //Read user input.

            int[] inputArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                inputArray[i] = int.Parse(usrInput[i]); //Assign user input to array.
            }

            MergeSort(inputArray, 0, size - 1);

            Console.WriteLine("The sorted array after applying Merge Sort ");

            for (int k = 0; k < inputArray.Length; k++)
            {
                Console.Write(inputArray[k] + " "); //Print the sorted array to console.
            }
            Console.ReadLine();
        }

        public static void MergeSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;        // divide the current array in 2 subarrays.
                MergeSort(arr, start, mid);        // sort the first part of array.
                MergeSort(arr, mid + 1, end);      // sort the second part of array.

                // merge the subarrays by comparing elements in them.
                Merge(arr, start, mid, end);
            }
        }

        public static void Merge(int[] arr, int start, int mid, int end)
        {
            int p = start, q = mid + 1;

            int[] tempArr = new int[end - start + 1];
            int k = 0;

            for (int i = start; i <= end; i++)
            {
                if (p > mid)					 //checks if first part comes to an end or not .
                    tempArr[k++] = arr[q++];

                else if (q > end)				//checks if second part comes to an end or not
                    tempArr[k++] = arr[p++];

                else if (arr[p] < arr[q])		//compare elements from both parts.
                    tempArr[k++] = arr[p++];

                else
                    tempArr[k++] = arr[q++];
            }
            for (int j = 0; j < k; j++)
            {
                //Now the original array has elements in sorted manner including both parts.
                arr[start++] = tempArr[j];
            }
        }
    }
}