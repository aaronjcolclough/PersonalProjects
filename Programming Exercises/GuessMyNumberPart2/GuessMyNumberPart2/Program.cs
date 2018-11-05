using System;

namespace GuessMyNumberPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implement bisection algorithm: Part 2");

            Random rdm = new Random();
            int num = rdm.Next(1, 1001);

            Console.WriteLine("Guess my number; it's between 1 and 1000.");
            Guess(num);            
        }

        private static void Guess(int num)
        {
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess > num)
            {
                Console.WriteLine("Too High! Try again.");
                Guess(num);
            }
            else if (guess < num)
            {
                Console.WriteLine("Too Low! Try again.");
                Guess(num);
            }
            else
            {
                Console.WriteLine("Good guess, you got it!");
            }
        }
    }
}
