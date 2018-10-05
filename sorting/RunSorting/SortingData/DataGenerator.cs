using System;
using System.Collections.Generic;
using System.Linq;

namespace AllAlgorithms.Csharp.Sorting.RunSorting.SortingData
{
    public sealed class DataGenerator
    {
        private readonly int Min = int.MinValue;
        private readonly int Max = int.MaxValue;
        private readonly Random Random = new Random();

        public GeneratedData Generate(int entries = 256)
        {
            var data = GenerateData(entries);
            return new GeneratedData(data);
        }

        private int[] GenerateData(int entries)
        {
            if (entries <= 2)
            {
                return new int[0];
            }

            var data = Enumerable
                .Repeat(0, entries)
                .Select(i => Random.Next(Min, Max))
                .ToArray();

            return data;
        }
    }
}
