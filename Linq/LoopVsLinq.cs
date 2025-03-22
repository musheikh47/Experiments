using BenchmarkDotNet.Attributes;

namespace Experiments.Linq
{
    [MemoryDiagnoser]
    public class LoopVsLinq
    {
        private List<int> data;

        [GlobalSetup]
        public void Setup()
        {
            data = Enumerable.Range(1, 1000).ToList();
        }

        [Benchmark]
        public List<int> Loop()
        {
            var result = new List<int>(data.Count);
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] > 3)
                    result.Add(data[i]);
            }
            result.Sort();
            return result;
        }

        [Benchmark]
        public List<int> Linq()
        {
            return data.Where(x => x > 3).OrderBy(x => x).ToList();
        }
    }
}
