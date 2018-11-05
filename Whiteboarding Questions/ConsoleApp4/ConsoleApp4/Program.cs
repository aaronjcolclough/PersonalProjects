using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanNum(int.Parse(Console.ReadLine())));
        }

        public static Dictionary<int, string> roman = new Dictionary<int, string>();

        private static string RomanNum(int v)
        {
            RomanNumerals.dicfill();
            string result = "";
            for (int i = 10; v != 0; i *= 10)
            {
                int tmp = (v % i);
                if (tmp > 999)
                {
                    string foo = new string('M', tmp / 1000);
                    result = string.Format($"{foo}{result}");
                }
                else
                {
                    roman.TryGetValue(tmp, out string n);
                    result = string.Format($"{n}{result}");
                }
                v = v - tmp;
            }
            return result;
        }

        private static string RomanNum2(int v)
        {
            string[] thou = { "M", "CM", "DCCC", "DCC", "DC", "D", "CD", "CCC", "CC", "C" };
            string[] tens = { "C", "XC", "LXXX", "LXX", "LX", "L", "XL", "XXX", "XX", "X" };
            string[] ones = { "X", "IX", "VIII", "VII", "VI", "V", "IV", "III", "II", "I" };

            StringBuilder roman = new StringBuilder();
            int tmp = 1000;
            
            for (int i = 0; i < thou.Length; i++)
            {
                int foo = v / tmp;
                if (foo > 1)
                {
                    roman.Append(Convert.ToChar(thou[i]), foo);
                    v = v - (tmp * foo);
                }
                else if (foo == 1)
                {
                    roman.Append(thou[i]);
                    v = v - tmp;
                }
                tmp -= 100;
            }
            tmp = 100;
            for (int i = 0; i < tens.Length; i++)
            {
                int foo = v / tmp;
                if (foo > 1)
                {
                    roman.Append(Convert.ToChar(tens[i]), foo);
                    v = v - (tmp * foo);

                }
                else if (foo == 1)
                {
                    roman.Append(tens[i]);
                    v = v - tmp;

                }
                tmp -= 10;
            }
            tmp = 10;
            for (int i = 0; v > 0; i++)
            {
                int foo = v / tmp;
                if (foo > 1)
                {
                    roman.Append(Convert.ToChar(ones[i]), foo);
                    v = v - (tmp * foo);

                }
                else if (foo == 1)
                {
                    roman.Append(ones[i]);
                    v = v - tmp;

                }
                tmp -= 1;
            }
            return roman.ToString();
        }
    }
}
