using System;

namespace GuessMyNumberPat3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implement bisection algorithm: Part 3");

            int start = 1;
            int end = 100;
            int guess = (end + start) / 2;

            Guess(guess, start, end);
        }

        private static void Guess(int guess, int start, int end)
        {
            Console.WriteLine("Responses can be: too high, too low, or you got it");
            Console.WriteLine($"I guess the number {guess}");

            string resp = Console.ReadLine();

            if (resp.ToLower() == "too high")
            {
                end = guess - 1;
                guess = (end + start) / 2;
                Guess(guess, start, end);
            }
            else if (resp.ToLower() == "too low")
            {
                start = guess + 1;
                guess = (end + start) / 2;
                Guess(guess, start, end);
            }
            else if (resp.ToLower() == "you got it")
            {
                Console.WriteLine("Good game!");
            }
        }
    }
}
