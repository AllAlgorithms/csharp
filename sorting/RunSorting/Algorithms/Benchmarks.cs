using AllAlgorithms.Csharp.Sorting.RunSorting.SortingData;
using BenchmarkDotNet.Attributes;
using System;

namespace AllAlgorithms.Csharp.Sorting.RunSorting.Algorithms
{
    public class Benchmarks
    {
        private readonly GeneratedData _generatedData;

        private readonly BubbleSort.BubbleSort bubbleSort = new BubbleSort.BubbleSort();
        private readonly Linq.Linq linqSort = new Linq.Linq();
        private readonly BogoSort.BogoSort bogoSort = new BogoSort.BogoSort();
        private readonly CocktailSort.CocktailSort cocktailSort = new CocktailSort.CocktailSort();
        private readonly InsertionSort.InsertionSort insertionSort = new InsertionSort.InsertionSort();
        private readonly MergeSort.MergeSort mergeSort = new MergeSort.MergeSort();
        private readonly QuickSort.QuickSort quickSort = new QuickSort.QuickSort();
        private readonly RadixSort.RadixSort radixSort = new RadixSort.RadixSort();
        private readonly SelectionSort.SelectionSort selectionSort = new SelectionSort.SelectionSort();

        public Benchmarks()
        {
            _generatedData = new DataGenerator().Generate(256);
        }

        [Benchmark]
        public int[] BubbleSort() => bubbleSort.Sort(_generatedData.AllData.Copy());

        [Benchmark]
        public int[] LinqOrderBy() => linqSort.OrderBy(_generatedData.AllData.Copy());

        [Benchmark]
        public int[] LinqGenericSort() => linqSort.GenericSort(_generatedData.AllData.Copy());

        [Benchmark]
        public int[] LinqTypedSort() => linqSort.TypedSort(_generatedData.AllData.Copy());

        // TODO : Locks up BenchmarkDotNet
        //[Benchmark]
        public int[] BogoSort() => bogoSort.Sort(_generatedData.AllData.Copy());

        [Benchmark]
        public int[] CocktailSort() => cocktailSort.Sort(_generatedData.AllData.Copy());

        [Benchmark]
        public int[] InsertionSort() => insertionSort.Sort(_generatedData.AllData.Copy());

        [Benchmark]
        public int[] Mergesort() => mergeSort.Sort(_generatedData.AllData.Copy());

        [Benchmark]
        public int[] QuickSort() => quickSort.Sort(_generatedData.AllData.Copy());

        [Benchmark]
        public int[] RadixSort() => radixSort.Sort(_generatedData.AllData.Copy());

        [Benchmark]
        public int[] SelectionSort() => selectionSort.Sort(_generatedData.AllData.Copy());
    }

    internal static class ExtentionMethods
    {
        public static int[] Copy(this int[] array)
        {
            int[] arrayCopy = new int[array.Length];
            Array.Copy(array, arrayCopy, array.Length);
            return arrayCopy;
        }
    }
}
