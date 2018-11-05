using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = "12345"; // should equal 51
            Console.WriteLine($"Numbers to add: {numbers}");

            int total = 0;
            total = GetTotals(total, numbers);
            Console.WriteLine($"total is {total}");
        }

        private static int GetTotals(int total, string numbers)
        {
            Console.WriteLine($"numbers: {numbers}, total: {total}");
            int len = numbers.Length;
            if (len == 0)
            {
                Console.WriteLine("   if clause, should not be CALLED");
                return (0);
            }
            else if (len == 1)
            {
                int n = int.Parse(numbers);
                total += n;
                Console.WriteLine($"    else if clause: total is {total} and n is {n}");
                return (total);
            }
            else // len is greater than 1
            {
                string pair = numbers.Substring(0, 2);
                int p = int.Parse(pair);
                total += p;
                Console.WriteLine($"    else clause: total is {total} and pair is {p}");
                return (GetTotals(total, numbers.Substring(2)));
            }
        }
    }
}
