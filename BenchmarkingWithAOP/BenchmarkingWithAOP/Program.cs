using System;
using System.Collections.Generic;

namespace BenchmarkingWithAOP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var benchmarkLimit = 100000000;
            var benchmarkList = new List<int>();
            var looptester = new LoopTester();

            for (var i = 0; i < benchmarkLimit; i++)
                benchmarkList.Add(i);

            looptester.ForEachTest(benchmarkList);
            looptester.DefaultForTest(benchmarkList);
            looptester.BetterForTest(benchmarkList);
            looptester.ReversedForTest(benchmarkList);

            Console.WriteLine("The end of tests");
            Console.ReadLine();
        }
    }
}