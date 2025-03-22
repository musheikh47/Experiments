using BenchmarkDotNet.Running;
using Experiments.Linq;

namespace Experiments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<LoopVsLinq>();
            Console.ReadLine();
        }
    }
}
