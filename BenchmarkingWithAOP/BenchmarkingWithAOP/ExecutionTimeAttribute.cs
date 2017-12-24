using System;
using System.Diagnostics;
using PostSharp.Aspects;
using PostSharp.Serialization;

namespace BenchmarkingWithAOP
{
    [PSerializable]
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class ExecutionTimeAttribute : OnMethodBoundaryAspect
    {
        private static readonly Stopwatch timer = new Stopwatch();

        public override void OnEntry(MethodExecutionArgs args)
        {
            timer.Start();
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            var timeInMilliseconds = timer.ElapsedMilliseconds;
            timer.Reset();
            timer.Stop();
            Console.WriteLine(timeInMilliseconds);
        }
    }
}