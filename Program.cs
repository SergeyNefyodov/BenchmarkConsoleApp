using BenchmarkDotNet.Running;

namespace BenchmarkConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<StringBenchmark>();
            Console.ReadLine();
        }
    }
}
