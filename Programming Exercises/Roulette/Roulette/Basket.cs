using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Basket
    {
        public Basket(int winnum)
        {
            if (winnum == 1 || winnum == 2 || winnum == 3)
            {
                Console.WriteLine("Basket (0, 00, 1, 2, 3)");
            }
        }
    }
}
