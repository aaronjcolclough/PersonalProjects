using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // create int array
            int evencount = 0;
            int oddcount = 0;
            //int[] array = new int[100];
            // fill array with numbers 1-100
            for (int i = 1; i <= 100; i++)
            {
                //array[i] = i + 1;

                // display whether or not even or odd
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is Even");
                    evencount++;
                }
                else
                {
                    Console.WriteLine($"{i} is Odd");
                    oddcount++;
                }
            }

            

            // determine number is even or odd
            //for (int j = 0; j < array.Length; j++)
            {
                
            }
            // display even and odd counts
            Console.WriteLine($"Even number count is {evencount}. Odd number count is {oddcount}.");
        }
    }
}
