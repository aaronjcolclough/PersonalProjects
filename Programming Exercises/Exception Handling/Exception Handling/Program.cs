﻿using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            optionmenu();
        }

        private static void optionmenu()
        {
            Console.WriteLine("1- Circumference and Area of a Circle");
            Console.WriteLine("2- Volume of a Hemisphere");
            Console.WriteLine("3- Area of a Triangle (Heron's Formula)");
            Console.WriteLine("4- Solving a Quadratic Equation");
            Console.WriteLine("Enter program to run:");
            int menu = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (menu == 1)
                {
                    Circle();
                }

                else if (menu == 2)
                {
                    VolHem();
                }

                else if (menu == 3)
                {
                    AreaTri();
                }

                else if (menu == 4)
                {
                    QuadEq();
                }

                else
                {
                    Console.WriteLine("Entry not available.");
                    optionmenu();
                }
            }
            catch (FormatException fEx)
            {
                Console.WriteLine("Error: {0}", fEx.Message);
                optionmenu(menu);
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine("Error: {0}", outOfRange.Message);
                optionmenu(menu);
            }
            catch (DivideByZeroException byZero)
            {
                Console.WriteLine("Error: {0}", byZero.Message);
                optionmenu(menu);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
                optionmenu(menu);
            }
            finally
            {
                Console.WriteLine("Your number is good.");
                optionmenu();
            }
        }

        private static void optionmenu(int menu)
        {
            try
            {
                if (menu == 1)
                {
                    Circle();
                }

                else if (menu == 2)
                {
                    VolHem();
                }

                else if (menu == 3)
                {
                    AreaTri();
                }

                else if (menu == 4)
                {
                    QuadEq();
                }
            }
            catch (FormatException fEx)
            {
                Console.WriteLine("Error: {0}", fEx.Message);
                optionmenu(menu);
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine("Error: {0}", outOfRange.Message);
                optionmenu(menu);
            }
            catch (DivideByZeroException byZero)
            {
                Console.WriteLine("Error: {0}", byZero.Message);
                optionmenu(menu);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
                optionmenu(menu);
            }
        }

        private static void Circle()
        {
            //Part1
            Console.WriteLine("\nPart 1 Circumference and Area of a circle");
            Console.WriteLine("Enter the radius of the circle:");
            string radius1 = Console.ReadLine();
            float r1 = float.Parse(radius1);

            if (r1 <= 0)
            {
                throw new ArgumentOutOfRangeException("radius", "Must have a radius greater than 0.");
            }

            float area1 = 2 * (float) Math.PI * r1;
            float circumference = (float) Math.PI * (float)Math.Pow(r1, 2);
            Console.WriteLine($"The circumference of the circle is {circumference}.");
            Console.WriteLine($"The area of the circle is {area1}.");
        }

        private static void VolHem()
        {
            //Part2
            Console.WriteLine("\nPart 2 Volume of a Hemisphere");
            Console.WriteLine("Enter the radius of the circle:");
            string radius2 = Console.ReadLine();
            float r2 = float.Parse(radius2);

            if (r2 <= 0)
            {
                throw new ArgumentOutOfRangeException("radius", "Must have a radius greater than 0.");
            }

            float volume = (float)((4.0 / 3.0) * Math.PI * Math.Pow(r2, 3)) / 2;
            Console.WriteLine($"The volume of a hemisphere of the circle is {volume}.");
        }

        private static void AreaTri()
        {
            //Part3
            Console.WriteLine("\nPart 3 Area of a Triangle (Heron's Formula)");
            Console.WriteLine("Enter length of first side:");
            string side1 = Console.ReadLine();
            int s1 = int.Parse(side1);

            if (s1 <= 0)
            {
                throw new ArgumentOutOfRangeException("side 1", "Must have a length greater than 0.");
            }

            Console.WriteLine("Enter length of second side:");
            string side2 = Console.ReadLine();
            int s2 = int.Parse(side2);

            if (s2 <= 0)
            {
                throw new ArgumentOutOfRangeException("side 2", "Must have a length greater than 0.");
            }

            Console.WriteLine("Enter length of third side:");
            string side3 = Console.ReadLine();
            int s3 = int.Parse(side3);

            if (s3 <= 0)
            {
                throw new ArgumentOutOfRangeException("side 3", "Must have a length greater than 0.");
            }

            float p =  (float) (s1 + s2 + s3) / 2;
            float area2 = (float)Math.Sqrt(p * (p - s1) * (p - s2) * (p - s3));
            Console.WriteLine($"The area of the triangle is {area2}.");
        }

        private static void QuadEq()
        {
            //Part4
            Console.WriteLine("\nPart 4 Solving a Quadratic Equation");

            Console.WriteLine("Enter the value of a:");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                throw new DivideByZeroException();
            }

            Console.WriteLine("Enter the value of b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of c:");
            int c = Convert.ToInt32(Console.ReadLine());           

            if (((b * b) - 4 * a * c) < 0)
            {
                throw new ArgumentOutOfRangeException("sqrt", "Square Root is not a real number.");
            }

            float x = (float)(-b + Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
            float x2 = (float)(-b - Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
            
            Console.WriteLine($"x = {x} and {x2}.");
        }
    }
}
