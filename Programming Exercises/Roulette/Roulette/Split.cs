using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Split
    {
        public Split(int winnum)
        {
            if (winnum % 3 == 1)
            {
                if (winnum == 1)
                {
                    Console.WriteLine("Split: 1 / 2 and 1 / 4");
                }
                else if (winnum == 34)
                {
                    Console.WriteLine("Split: 31 / 34 and 34 / 35");
                }
                else
                {
                    Console.WriteLine($"Split: {winnum - 3} / {winnum}, {winnum} / {winnum + 1}, {winnum} / {winnum + 3}");
                }
            }
            else if (winnum % 3 == 2)
            {
                if (winnum == 2)
                {
                    Console.WriteLine("Split: 1 / 2, 2 / 3 and 2 / 5");
                }
                else if (winnum == 35)
                {
                    Console.WriteLine("Split: 32 / 35, 34 / 35 and 35 / 36");
                }
                else
                {
                    Console.WriteLine($"Split: {winnum - 3} / {winnum}, {winnum - 1} / {winnum}, {winnum} / {winnum + 1}, {winnum} / {winnum + 3}");
                }
            }
            else
            {
                if (winnum == 3)
                {
                    Console.WriteLine("Split: 2 / 3 and 3 / 6");
                }
                else if (winnum == 36)
                {
                    Console.WriteLine("Split: 33 / 36 and 35 / 36");
                }
                else
                {
                    Console.WriteLine($"Split: {winnum - 3} / {winnum}, {winnum - 1} / {winnum}, {winnum} / {winnum + 3}");
                }
            }
        }
    }
}
