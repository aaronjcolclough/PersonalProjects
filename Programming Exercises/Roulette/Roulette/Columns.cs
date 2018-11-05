using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Columns
    {
        public Columns(int winnum)
        {
            if (winnum % 3 == 1)
            {
                Console.WriteLine("First Column");
            }
            else if (winnum % 3 == 2)
            {
                Console.WriteLine("Second Column");
            }
            else
            {
                Console.WriteLine("Third Column");
            }
        }
    }
}
