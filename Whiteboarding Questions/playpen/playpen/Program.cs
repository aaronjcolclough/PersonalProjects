using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace playpen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            Console.WriteLine(dirReduc(a));
            
            //Console.WriteLine(thirt(1234567));
            //Console.WriteLine(thirt(87));
            int[] a = { 2, 4 };
            int[] b = { 1, 2, 2, 2, 3, 3, 4 };
            Diff(a,b);
            
            */
        }
        /*
        private static void Diff(int[] a, int[] b)
        {
            //List<int> bar = b.ToList();
            int[] c = b.Except(a).ToArray();
            foreach (int i in c)
            {
                Console.WriteLine(i);
            }
        }
        */
        /*public static string Compression(string v)
        {
            string result = "";
            int count = 1;
            for (int i = 0, j = 1; j < v.Length; i++, j++)
            {
                if (v[i] == v[j])
                {
                    count++;
                    if (j == v.Length - 1)
                    {
                        result = string.Format("{0}{1}", result, $"{v[j]}{count}");
                    }
                }
                else
                {
                    result = string.Format("{0}{1}", result, $"{v[i]}{count}");
                    count = 1;
                    if (j == v.Length - 1)
                    {
                        result = string.Format("{0}{1}", result, $"{v[j]}{count}");
                    }
                }
            }
            return result;
        }

        private static int thirt(int n)
        {
            int[] pows = { 1, 10, 9, 12, 3, 4 };
            int total = 0;


            do
            {
                int[] bar = n.ToString().ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();

                for (int i = bar.Length - 1, j = 0; i >= 0; i--, j++)
                {
                    if (j == pows.Length)
                    {
                        j = 0;
                    }
                    total += bar[i] * pows[j];
                }
            }
            while (total != n);

            return total;
        }
        */
        /*
        public static string[] dirReduc(String[] arr)
        {
            string[] spam 
            List<string> foo = arr.ToList();
            int current = 0;
            do
            {
                if ((foo[0] == "NORTH" && foo[1] == "SOUTH") ||
                    (foo[0] == "SOUTH" && foo[1] == "NORTH") ||
                    (foo[0] == "EAST" && foo[1] == "WEST") ||
                    (foo[0] == "WEST" && foo[1] == "EAST"))
                {
                    foo.Remove(foo[current]);
                    foo.Remove(foo[current + 1]);
                    Console.WriteLine(foo.Count());

                }
                else if ()
                else                
                    break;
                
            }
            while (true);
            string[] bar = foo.ToArray();
            foreach (string i in bar)
                Console.WriteLine(i);
            return bar;
        }
        */




        /*public static int Persistence(long n)
        {
            
            int count = 0;
            if (n < 9)
            {
                return count;
            }
            do
            {
                    count++;
                    string foo = n.ToString();
                    int[] bar = foo.ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();

                    int total = 1;
                    foreach (int i in bar)
                    {
                        total *= i;
                    }
                    n = total;
            }
            while (n > 9);
            return count;
        }
        */
    }
}

