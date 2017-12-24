using System;
using System.Collections.Generic;

namespace BenchmarkingWithAOP
{
    public class LoopTester
    {
        [ExecutionTime]
        public void ForEachTest(IList<int> benchmarkList)
        {
            foreach (var elem in benchmarkList)
                if (elem % 100000000 == 0)
                    Console.WriteLine("foreach fired score below");
        }

        [ExecutionTime]
        public void DefaultForTest(IList<int> benchmarkList)
        {
            for (var i = 0; i < benchmarkList.Count; i++)
                if (benchmarkList[i] % 100000000 == 0)
                    Console.WriteLine("default for fired score below");
        }

        [ExecutionTime]
        public void BetterForTest(IList<int> benchmarkList)
        {
            var sizeOfList = benchmarkList.Count;
            for (var i = 0; i < sizeOfList; i++)
                if (benchmarkList[i] % 100000000 == 0)
                    Console.WriteLine("preassigned for fired score below");
        }

        [ExecutionTime]
        public void ReversedForTest(IList<int> benchmarkList)
        {
            var sizeOfList2 = benchmarkList.Count;
            for (var i = sizeOfList2 - 1; i >= 0; i--)
                if (benchmarkList[i] % 100000000 == 0)
                    Console.WriteLine("reversed for fired score below");
        }
    }
}