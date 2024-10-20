using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkConsoleApp
{
    internal class MyStringComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            {
                if (x == y) return 0;
                if (x is null) return -1;
                if (y is null) return 1;
                x = x.TrimStart('0');
                y = y.TrimStart('0');
                if (int.TryParse(x, out int intX) && int.TryParse(y, out int intY))
                {
                    return intX.CompareTo(intY);
                }
                if (int.TryParse(x, out _)) return 1;
                if (int.TryParse(y, out _)) return -1;
                return x.CompareTo(y);
            }
        }
    }
}
