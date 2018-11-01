using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Sorting_Algorithms_In_C_Sharp
{
    public static class BucketSort
    {
        public static List<int> BucketSort1(params int[] x)
        {
            List<int> result = new List<int>();
            int numOfBuckets = 10;
 
            List<int>[] buckets = new List<int>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
                buckets[i] = new List<int>();
 
            for (int i = 0; i < x.Length; i++)
            {
                int buckitChoice = (x[i] / numOfBuckets);
                buckets[buckitChoice].Add(x[i]);
            }
 
            for (int i = 0; i < numOfBuckets; i++)
            {
                int [] temp = BubbleSortList(buckets[i]);
                result.AddRange(temp);
            }
            return result;
        }
 
        public static int[] BubbleSortList(List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    if (input[i] < input[j])
                    {
                        int temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input.ToArray();
        }
    }
}