using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {

            DecimalToBinary();

            Console.ReadKey();
        }

        private static void DecimalToBinary()
        {
            Console.Write("Please Enter a Decimal Number: ");

            int inputDecimalNumber = Convert.ToInt32(Console.ReadLine());

            string resultOfBinary;

            resultOfBinary = string.Empty;
            while (inputDecimalNumber > 1)
            {
                int remainder = inputDecimalNumber % 2;
                resultOfBinary = Convert.ToString(remainder) + resultOfBinary;
                inputDecimalNumber /= 2;
            }
            resultOfBinary = Convert.ToString(inputDecimalNumber) + resultOfBinary;
            Console.WriteLine("Result In Binary Number: " + resultOfBinary);
        }
    }
}
