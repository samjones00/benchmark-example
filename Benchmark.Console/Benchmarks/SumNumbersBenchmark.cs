using Benchmark.Core;
using BenchmarkDotNet.Attributes;

namespace Benchmark.Console
{
    public class SumNumbersBenchmark
    {
        private static readonly ExampleService process = new ExampleService();

        [Benchmark]
        public void Linq() => process.Linq();

        [Benchmark]
        public void ForEach() => process.ForEach();
    }
}