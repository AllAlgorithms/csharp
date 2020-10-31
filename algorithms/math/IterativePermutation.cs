using System;
using System.Linq;
 
public static class GeneratePermutationsIteratively
{
    public static void Main()
    {
        Console.WriteLine("Enter a number: ");
        var num = int.Parse(Console.ReadLine());
 
        var numberOfPerm = 1;
        var elements = Enumerable.Range(1, num).ToArray();
        var workArr = Enumerable.Range(0, elements.Length + 1).ToArray();
 
        PrintPerm(elements);
        var index = 1;
        while (index < elements.Length)
        {
            workArr[index]--;
            var j = 0;
            if (index % 2 == 1)
            {
                j = workArr[index];
            }
 
            SwapInts(ref elements[j], ref elements[index]);
            index = 1;
            while (workArr[index] == 0)
            {
                workArr[index] = index;
                index++;
            }
 
            numberOfPerm++;
            PrintPerm(elements);
        }
 
        Console.WriteLine("Total permutations: {0}", numberOfPerm);
    }
 
    private static void PrintPerm(int[] elements)
    {
        Console.WriteLine(string.Join(", ", elements));
    }
 
    private static void SwapInts(ref int a, ref int b)
    {
        a ^= b;
        b ^= a;
        a ^= b;
    }
}