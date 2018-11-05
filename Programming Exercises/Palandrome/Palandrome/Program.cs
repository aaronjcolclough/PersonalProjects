using System;

namespace Palandrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter palandrome test:");
            string phrase = Console.ReadLine();
            Console.WriteLine($"You entered {phrase}.");

            for (int i = 0, j = phrase.Length - 1; i <= j; i++, j--)
            {
                Console.WriteLine($"{i} {j} {phrase[i]} {phrase[j]}");                
            }

            char[] pal = { 'm', 'a', 'd', 'a', 'm', 'i', 'm', 'a', 'd', 'a', 'm' };
            bool isPal = true;
            for (int i = 0, j = pal.Length - 1; i <= j; i++, j--)
            {
                Console.WriteLine($"{i} {j} {pal[i]} {pal[j]}");
                if (pal[i] == pal[j] && i == j)
                {
                    Console.WriteLine($"pal is {isPal}");
                }
            }
        }
    }
}
