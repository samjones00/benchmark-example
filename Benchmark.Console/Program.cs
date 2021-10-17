using BenchmarkDotNet.Running;
using System;

namespace Benchmark.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<SumNumbersBenchmark>();
        }
    }
}
