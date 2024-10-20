using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkConsoleApp
{
    public class Win32Comparer : IComparer<string>
    {
        [DllImport("shlwapi.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int StrCmpLogicalW(string s1, string s2);

        public int Compare(string? x, string? y)
        {
            return StrCmpLogicalW(x, y);
        }

    }
}
