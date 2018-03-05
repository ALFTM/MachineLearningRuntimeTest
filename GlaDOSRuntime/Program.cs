using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace GlaDOSRuntime
{
    class Program
    {
        static void Main(string[] args)
        {
            glaDOS();
            Console.ReadKey();
        }

        [DllImport("GlaDOS.dll")]
        static extern int glaDOS();

    }
}
