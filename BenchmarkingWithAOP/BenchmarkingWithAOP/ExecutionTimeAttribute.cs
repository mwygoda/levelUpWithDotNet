using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using PostSharp.Aspects;
using PostSharp.Serialization;

namespace BenchmarkingWithAOP
{
    [PSerializable]

    [AttributeUsage(AttributeTargets.Method)]
    public sealed class ExecutionTimeAttribute : OnMethodBoundaryAspect
    {
        private static Stopwatch timer = new Stopwatch();

        public override void OnEntry(MethodExecutionArgs args)
        {
            timer.Start();
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            var timeInMilliseconds = timer.ElapsedMilliseconds;
            timer.Stop();
            Console.WriteLine(timeInMilliseconds);
        }
    }
}
