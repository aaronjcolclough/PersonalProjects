using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  A     A   RRRR   OOO  N   N");
            Console.WriteLine(" A A   A A  R   R O   O NN  N");
            Console.WriteLine("A   A A   A RRRR  O   O N N N");
            Console.WriteLine("AAAAA AAAAA R  R  O   O N  NN");
            Console.WriteLine("A   A A   A R   R  OOO  N   N");
            /*
            double foo = (1 + Math.Sqrt(5)) / 2;
            Console.WriteLine(foo);

            long x = 1;
            long y = 1;
            int count = 2;

            Fib(count, x, y);
            
            Firearm shotgun = new Firearm("shotgun", "boom");
            Firearm pistol = new Firearm("pistol", "pop");
            Firearm rifle = new Firearm("rifle", "bang");
            Console.WriteLine(shotgun.Name);
            Console.WriteLine(shotgun.Sound);
            Console.WriteLine(rifle.Name);
            Console.WriteLine(rifle.Sound);
            Console.WriteLine(pistol.Name);
            Console.WriteLine(pistol.Sound);
            */
        }


        private static void Fib(int count, long i, long j)
        {
            if (count < 100)
            {
                long z = i + j;
                count = count + 1;
                Console.WriteLine($"{j} / {i}");

                Fib(count, j, z);
            }
            //else
                //Console.WriteLine($"{j} / {i}");
            

        }
    }
}
