using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChange
{
    class CoinChange
    {
        const int LENGTH = 15;
        int[] coins; // Coins Type
        int[][] memos = new int[LENGTH][]; // Used For Memoization

        public CoinChange(int[] coins)
        {
            this.coins = coins;

            for (int i = 0; i < LENGTH; i++)
            {
                memos[i] = new int[LENGTH];

                for (int j = 0; j < LENGTH; j++)
                {
                    memos[i][j] = -1; // Initialize Default Value
                }
            }
        }

        public int Start(int currentIndex, int currentValue)
        {
            if (currentIndex >= coins.Length || currentValue < 0)
                return 0;

            if (currentValue == 0)
                return 1;

            if (memos[currentIndex][currentValue] != -1)
                return memos[currentIndex][currentValue];

            int totalWays = 0;

            totalWays += Start(currentIndex, currentValue - coins[currentIndex]);
            totalWays += Start(currentIndex + 1, currentValue);
            memos[currentIndex][currentValue] = totalWays;

            return totalWays;
        }


        static void Main(string[] args)
        {
            int moneyToReturn = 7;
            int[] coinTypes = { 2, 3, 5 };

            CoinChange coinChangeCalculator = new CoinChange(coinTypes);
            int totalWays = coinChangeCalculator.Start(0, moneyToReturn);

            Console.WriteLine("Total Ways To Return {0} is {1}.", moneyToReturn, totalWays);
            Console.ReadKey(); // Hold The Screen
        }
    }
}
