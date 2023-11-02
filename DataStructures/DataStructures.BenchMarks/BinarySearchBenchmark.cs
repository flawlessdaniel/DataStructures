using BenchmarkDotNet.Attributes;

namespace DataStructures.BenchMarks
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class BinarySearchBenchmark
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        [Benchmark]
        public void SearchWithInterativeFunction()
        {
            _ = BinarySearch.SearchIterable(array, 3);
        }

        [Benchmark]
        public void SearchWithRecursiveFunction()
        {
            _ = BinarySearch.SearchRecursively(array, 3);
        }
    }
}
