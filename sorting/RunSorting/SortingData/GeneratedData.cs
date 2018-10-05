using System.Linq;

namespace AllAlgorithms.Csharp.Sorting.RunSorting.SortingData
{
    public sealed class GeneratedData
    {
        public GeneratedData(int[] data)
        {
            AllData = data;

            if (IsEven(data.Length))
            {
                DataPartA = data.Take(data.Length / 2).ToArray();
                DataPartB = data.Skip(data.Length / 2).ToArray();
            }
            else
            {
                DataPartA = data.Take((data.Length + 1) / 2).ToArray();
                DataPartB = data.Skip((data.Length + 1) / 2).ToArray();
            }
        }

        public int[] AllData { get; }

        public int[] DataPartA { get; }

        public int[] DataPartB { get; }

        private static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
    }
}
