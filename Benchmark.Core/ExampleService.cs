using System;
using System.Linq;

namespace Benchmark.Core
{
    public class ExampleService
    {
        public int[] Values = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public void Linq()
        {
            var sum = Values.Sum();
        }

        public void ForEach()
        {
            var sum = 0;

            foreach (var item in Values)
            {
                sum += item;
            }
        }
    }
}
