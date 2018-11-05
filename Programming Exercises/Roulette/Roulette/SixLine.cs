using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class SixLine
    {
        public SixLine(int winnum)
        {
            if (winnum % 3 == 1)
            {
                if (winnum == 1)
                {
                    Console.WriteLine("Six Line: 1 to 6");
                }
                else if (winnum == 34)
                {
                    Console.WriteLine("Six Line: 31 to 36");
                }
                else
                {
                    Console.WriteLine($"Six Line: {winnum - 3} to {winnum + 2} and {winnum} to {winnum + 5}");
                }
            }
            else if (winnum % 3 == 2)
            {
                if (winnum == 2)
                {
                    Console.WriteLine("Six Line: 1 to 6");
                }
                else if (winnum == 35)
                {
                    Console.WriteLine("Six Line: 31 to 36");
                }
                else
                {
                    Console.WriteLine($"Six Line: {winnum - 4} to {winnum + 1} and {winnum - 1} to {winnum + 4}");
                }
            }
            else
            {
                if (winnum == 3)
                {
                    Console.WriteLine("Six Line: 1 to 6");
                }
                else if (winnum == 36)
                {
                    Console.WriteLine("Six Line: 31 to 36");
                }
                else
                {
                    Console.WriteLine($"Six Line: {winnum - 5} to {winnum} and {winnum - 2} to {winnum + 3}");
                }
            }
        }
    }
}
