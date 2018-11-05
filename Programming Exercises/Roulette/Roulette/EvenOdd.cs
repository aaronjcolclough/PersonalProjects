using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class EvenOdd
    {
        public EvenOdd(int winnum)
        {
            if (winnum % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
