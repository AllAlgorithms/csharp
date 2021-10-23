using System;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryToDecimal();
            Console.ReadKey();
        }

        private static void BinaryToDecimal()
        {
            Console.Write("Please Enter the Binary Number:  ");
            int ThebinaryNumber = int.Parse(Console.ReadLine());
            int DecimalValueNumber = 0;
            int Base1Number = 1;

            while (ThebinaryNumber > 0)
            {
                int ReminderNumber = ThebinaryNumber % 10;
                ThebinaryNumber = ThebinaryNumber / 10;
                DecimalValueNumber += ReminderNumber * Base1Number;
                Base1Number = Base1Number * 2;
            }
            Console.Write("Result of Decimal Value :  " + DecimalValueNumber);
        }
    }
}
