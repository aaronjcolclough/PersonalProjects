using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Street
    {
        public Street(int winnum)
        {
            if (winnum % 3 == 1)
            {
                Console.WriteLine($"Street: {winnum} / {winnum + 1} / {winnum + 2}");
            }
            else if (winnum % 3 == 2)
            {
                Console.WriteLine($"Street: {winnum - 1} / {winnum} / {winnum + 1}");
            }
            else
            {
                Console.WriteLine($"Street: {winnum - 2} / {winnum - 1} / {winnum}");
            }
        }
    }
}
