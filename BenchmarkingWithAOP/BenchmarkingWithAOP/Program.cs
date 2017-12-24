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

            for (int i = 0; i < benchmarkLimit; i++)
            {
               benchmarkList.Add(i);
            }

            //foreach
            foreach (var elem in benchmarkList)
            {
                if (elem % 200000 == 0)
                {
                    Console.WriteLine("foreach fired");
                }
            }
            //poor? for
            for (int i = 0; i < benchmarkList.Count; i++)
            {
                if (benchmarkList[i] % 200000 == 0)
                {
                    Console.WriteLine("default for fired");
                }
            }
            //better? for
            var sizeOfList = benchmarkList.Count;
            for (int i = 0; i < sizeOfList; i++)
            {
                if (benchmarkList[i] % 200000 == 0)
                {
                    Console.WriteLine("preassigned for fired");
                }
            }

            //reversed for
            var sizeOfList2 = benchmarkList.Count;
            for (int i = sizeOfList2; i --> 0;)
            {
                if (benchmarkList[i] % 200000 == 0)
                {
                    Console.WriteLine("reversed for fired");
                }
            }

            Console.ReadLine();
        }
    }
}
