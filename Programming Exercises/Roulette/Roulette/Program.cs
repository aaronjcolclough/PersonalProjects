using System;
using System.Linq;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Roulette");
            Console.WriteLine("Press enter to spin the wheel");
            Console.ReadLine();
            
            spin();
        }       

        private static void spin()
        {
            Random rnd = new Random();
            int spin = rnd.Next(0, Bins.numbers.Length);
            int win = int.Parse(Bins.numbers[spin]);

            Console.WriteLine();
            Console.WriteLine($"Winning number is {win}");
            bets(win);
        }

        private static void bets(int win)
        {
            Console.WriteLine("Winners are:");

            if (Bins.numbers[win] == "0" || Bins.numbers[win] == "00")
            {
                Zeros zero = new Zeros(win);
            }
            else
            {
                EvenOdd evenodd = new EvenOdd(win);

                RedBlack color = new RedBlack(win);

                Halves halves = new Halves(win);

                Thirds thirds = new Thirds(win);

                Columns cols = new Columns(win);

                Street street = new Street(win);

                Split split = new Split(win);

                SixLine sixline = new SixLine(win);

                Corners corner = new Corners(win);

                Basket basket = new Basket(win);                
            }

            Console.WriteLine();
            Console.WriteLine("Would you like to spin again? Yes or No");
            playAgain();
        }

        private static void playAgain()
        {
            string ans = Console.ReadLine();

            if (ans.ToLower() == "yes")
            {
                spin();
            }
            else if (ans.ToLower() == "no")
            {
                Console.WriteLine("Thank you for playing, goodbye.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Are you drunk? I asked if you want to play again. Yes or No ");
                playAgain();
            }
        }
    }
}
