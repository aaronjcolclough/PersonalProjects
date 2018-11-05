using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Thirds
    {
        public Thirds(int winnum)
        {
            if (winnum <= 12)
            {
                Console.WriteLine("Lower Third");
            }
            else if (winnum <= 24 && winnum > 12)
            {
                Console.WriteLine("Middle Third");
            }
            else
            {
                Console.WriteLine("Upper Third");
            }
        }
    }
}
