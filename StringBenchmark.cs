using BenchmarkDotNet.Attributes;
using GihanSoft.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Jobs;

namespace BenchmarkConsoleApp
{
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net80)]
    [SimpleJob(RuntimeMoniker.Net48)]
    public class StringBenchmark
    {
        private readonly string[] _numbers =
        {
            "99", "98", "97", "094", "93", "85", "81", "079", "73", "72", "60", "0052", "51", "50", "47",
            "43", "42", "041", "35", "00030", "21", "019", "18", "11", "10", "09", "5", "4", "03", "1",
        };

        [Benchmark]
        public List<string> Copy()
        {
            var list = new List<string>(_numbers);
            return list;
        }

        [Benchmark]
        public List<string> SortV1()
        {
            var list = new List<string>(_numbers);
            list.Sort(new MyStringComparer());
            return list;
        }

        [Benchmark]
        public List<string> SortV2()
        {
            var list = new List<string>(_numbers);
            list.Sort(new Win32Comparer());
            return list;
        }
        
        [Benchmark]
        public List<string> SortV3()
        {
            var list = new List<string>(_numbers);
            list.Sort(new NaturalComparer(StringComparison.Ordinal));
            return list;
        }
    }
}
