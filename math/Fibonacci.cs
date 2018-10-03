using System;

class Fibonacci
{
    static List<UInt64> Fibonacci(int limit)
    {
        List<UInt64> result = new List<UInt64>();
        if (limit > 100)
            throw new ArgumentOutOfRangeException();
        // Setting the 1st and 2nd number of the series
        result.Add(0);
        result.Add(1);

        for (int i = 2; i <= limit; i++)
            result.Add(result[i - 1] + result[i - 2]);

        return result;
    }
    public static void main(string[] args)
    {
        Console.WriteLine("This program display Fibonacci series upto a desired limit.");
        Console.Write("Enter a limit for the Fibonacci series (1 - 100) : ");
        string limit = Console.ReadLine();
        try
        {
            Console.WriteLine($"Fibonacci Series : \n{String.Join(",\r\n", Fibonacci(Int32.Parse(limit)))}");
        }
        catch (Exception ae)
        {
            Console.WriteLine($"Error: {ae.Message}");
        }
    }
}