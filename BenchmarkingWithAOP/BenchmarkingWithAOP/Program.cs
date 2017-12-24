using System;
using System.Collections.Generic;
using System.Linq;

namespace BenchmarkingWithAOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var benchmarkLimit = 100000000;
            var benchmarkList = new List<int>();
            var looptester = new LoopTester();

            for (int i = 0; i < benchmarkLimit; i++)
            {
                benchmarkList.Add(i);
            }

            looptester.ForEachTest(benchmarkList);
            looptester.DefaultForTest(benchmarkList);
            looptester.BetterForTest(benchmarkList);
            looptester.ReversedForTest(benchmarkList);

            Console.WriteLine("The end of tests");
            Console.ReadLine();
        }
    }
}