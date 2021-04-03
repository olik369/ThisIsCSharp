using System;
using static System.Console;

namespace chp1.ArithmaticOperators
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 111 + 222;
            WriteLine($"a : {a}");

            int b = a - 100;
            WriteLine($"b : {b}");

            int c = b * 10;
            WriteLine($"c : {c}");

            double d = c / 6.3;
            WriteLine($"d : {d}");

            WriteLine($"22 / 7 = {22 / 7}({22 % 7})");  // = 몫(나머지)
        }
    }
}
