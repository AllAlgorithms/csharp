using AllAlgorithms.Csharp.Sorting.RunSorting.SortingData;
using BenchmarkDotNet.Attributes;

namespace AllAlgorithms.Csharp.Sorting.RunSorting.Algorithms
{
    public class Benchmarks
    {
        private readonly GeneratedData _generatedData;

        private readonly BubbleSort.BubbleSort bubbleSortVariance = new BubbleSort.BubbleSort();
        private readonly Linq.Linq linqVariance = new Linq.Linq();

        public Benchmarks()
        {
            _generatedData = new DataGenerator().Generate(256);
        }

        [Benchmark]
        public int[] BubbleSort() => bubbleSortVariance.Sort(_generatedData.AllData);

        [Benchmark]
        public int[] LinqOrderBy() => linqVariance.OrderBy(_generatedData.AllData);

        [Benchmark]
        public int[] LinqGenericSort() => linqVariance.GenericSort(_generatedData.AllData);

        [Benchmark]
        public int[] LinqTypedSort() => linqVariance.TypedSort(_generatedData.AllData);
    }
}
