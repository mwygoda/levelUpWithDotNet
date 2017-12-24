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
        private static readonly Stopwatch Timer = new Stopwatch();

        public override void OnEntry(MethodExecutionArgs args)
        {
            Timer.Start();
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            var timeInMilliseconds = Timer.ElapsedMilliseconds;
            Timer.Reset();
            Timer.Stop();
            Console.WriteLine(timeInMilliseconds);
        }
    }
}