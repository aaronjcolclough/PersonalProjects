using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class RomanNumerals
    {
        public static void dicfill()
        {
            Program.roman.Add(0, "");
            Program.roman.Add(1, "I");
            Program.roman.Add(2, "II");
            Program.roman.Add(3, "III");
            Program.roman.Add(4, "IV");
            Program.roman.Add(5, "V");
            Program.roman.Add(6, "VI");
            Program.roman.Add(7, "VII");
            Program.roman.Add(8, "VIII");
            Program.roman.Add(9, "IX");
            Program.roman.Add(10, "X");
            Program.roman.Add(20, "XX");
            Program.roman.Add(30, "XXX");
            Program.roman.Add(40, "XL");
            Program.roman.Add(50, "L");
            Program.roman.Add(60, "LX");
            Program.roman.Add(70, "LXX");
            Program.roman.Add(80, "LXXX");
            Program.roman.Add(90, "XC");
            Program.roman.Add(100, "C");
            Program.roman.Add(200, "CC");
            Program.roman.Add(300, "CCC");
            Program.roman.Add(400, "CD");
            Program.roman.Add(500, "D");
            Program.roman.Add(600, "DC");
            Program.roman.Add(700, "DCC");
            Program.roman.Add(800, "DCCC");
            Program.roman.Add(900, "CM");
            Program.roman.Add(1000, "M");
        }
    }
}
