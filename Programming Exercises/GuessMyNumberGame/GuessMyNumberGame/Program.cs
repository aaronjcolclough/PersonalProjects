using System;
using System.Linq;

namespace GuessMyNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implement bisection algorithm: Part 1");

            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Pick a number between 1 and 10.");

            int value = Pick(list);
            


            Bisection_search(value, list);
        }

        private static int Pick(int[] list)
        {
            int value = Convert.ToInt32(Console.ReadLine());
            if (list.Contains(value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("That's not between 1 and 10. Try again.");
                Pick(list);
                return 0;
            }
        }

        private static void Bisection_search(int value, int[] list)
        {
            if (list.Length == 1)
            {
                Console.WriteLine($"Number is {list[0]}");
            }
            else
            {
                int start = list[0];
                int end = list[list.Length - 1];
                int guess = (end + start) / 2;

                int half = (int)Math.Ceiling(list.Length / 2.0);

                if (guess < value)
                {

                    Console.WriteLine($"Number is higher than {guess}");
                    Console.Write("List is now set to {");
                    int[] list2 = new int[end - guess];
                    for (int i = 0, j = half; i < list2.Length; i++, j++)
                    {
                        list2[i] = list[j];
                        Console.Write($"{list2[i]} ");
                    }
                    Console.Write("}");
                    Console.WriteLine();
                    Bisection_search(value, list2);
                }

                else if (guess > value)
                {
                    Console.WriteLine($"Number is less than {guess}");
                    Console.Write("List is now set to {");
                    int[] list2 = new int[guess - start];
                    for (int i = 0; i < list2.Length; i++)
                    {
                        list2[i] = list[i];
                        Console.Write($"{list2[i]} ");
                    }
                    Console.Write("}");
                    Console.WriteLine();
                    Bisection_search(value, list2);
                }

                else
                    Console.WriteLine($"Number is {guess}");
            }            
        }
    }
}
