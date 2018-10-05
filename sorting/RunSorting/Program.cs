using AllAlgorithms.Csharp.Sorting.RunSorting.Algorithms;
using BenchmarkDotNet.Running;

namespace RunSorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            RunSorts();
        }

        private static void RunSorts()
        {
            BenchmarkRunner.Run<Benchmarks>();
        }
    }
}