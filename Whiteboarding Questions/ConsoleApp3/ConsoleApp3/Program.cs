using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sum(999));
        }

        private static int sum(int v)
        {
            return v.ToString().Select(x => int.Parse(x.ToString())).ToArray().Sum(); ;

        }
    }
}
