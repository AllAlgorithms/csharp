using System;

class Factorial
{
    static public UInt64 Factorial(UInt64 n)
    {
        if (n == 0)
            return 1;
        else if (n >= 0 && n <= 50)
            return n * Factorial(n - 1);
        else if (n < 0 || n > 50)
            throw new ArgumentOutOfRangeException();

        return 0;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("This program calculates Factorial of a number.");
        Console.Write("Enter any number (1 - 50) : ");
        string num = Console.ReadLine();
        try
        {
            UInt64 factorial = Factorial(UInt64.Parse(num));
            Console.WriteLine($"Factorial of {num} is {factorial}");
        }
        catch (Exception ae)
        {
            Console.WriteLine($"Error: {ae.Message}");
        }
        Console.ReadLine();
    }
}