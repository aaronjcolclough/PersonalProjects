using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Halves
    {
        public Halves(int winnum)
        {
            if (winnum <= 18)
            {
                Console.WriteLine("Lower 18");
            }
            else
            {
                Console.WriteLine("Upper 18");
            }
        }
    }
}
