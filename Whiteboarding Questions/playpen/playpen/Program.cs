using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Diagnostics;

namespace playpen
{
    class Program
    {
        public static Stopwatch stopWatch = new Stopwatch();
        public static double pi;
        static void Main(string[] args)
        {
            pi = CalcPi();
            
            Console.WriteLine($"Pi is: {pi} and was calculated in {stopWatch.Elapsed}");
            Console.WriteLine(Math.PI);
        }

        private static double CalcPi()
        {
            stopWatch.Start();
            for (int i = 1; pi != Math.PI; i += 4)
            {
                pi += (4.0 / i) - (4.0 / (i + 2));
            }
            stopWatch.Stop();
            return pi;
        }
    }
}

