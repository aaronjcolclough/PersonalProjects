using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Corners
    {
        public Corners(int winnum)
        {
            if (winnum % 3 == 1)
            {
                if (winnum == 1)
                {
                    Console.WriteLine("Corners: 1 / 2 / 4 / 5");
                }
                else if (winnum == 34)
                {
                    Console.WriteLine("Corners: 31 / 32 / 34 / 35");
                }
                else
                {
                    Console.WriteLine($"Corners: {winnum - 3} / {winnum - 2} / {winnum} / {winnum + 1} and {winnum} / {winnum + 1} / {winnum + 3} / {winnum + 4}");
                }
            }
            else if (winnum % 3 == 2)
            {
                if (winnum == 2)
                {
                    Console.WriteLine("Corners: 1 / 2 / 4 / 5 and 2 / 3 / 5 / 6");
                }
                else if (winnum == 35)
                {
                    Console.WriteLine("Corners: 31 / 32 / 34 / 35 and 32 / 33 / 35 / 36");
                }
                else
                {
                    Console.WriteLine($"Corners: {winnum - 4} / {winnum - 3} / {winnum - 1} / {winnum}, {winnum - 3} / {winnum - 2} / {winnum} / {winnum + 1}, " +
                        $"{winnum - 1} / {winnum} / {winnum + 2} / {winnum + 3} and {winnum} / {winnum + 1} / {winnum + 3} / {winnum + 4}");
                }
            }
            else
            {
                if (winnum == 3)
                {
                    Console.WriteLine("Corners: 2 / 3 / 5 / 6");
                }
                else if (winnum == 36)
                {
                    Console.WriteLine("Corners: 32 / 33 / 35 / 36");
                }
                else
                {
                    Console.WriteLine($"Corners: {winnum - 4} / {winnum - 3} / {winnum - 1} / {winnum} and {winnum - 1} / {winnum} / {winnum + 2} / {winnum + 3}");
                }
            }
        }
    }
}
