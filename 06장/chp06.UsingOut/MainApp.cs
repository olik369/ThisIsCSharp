using System;
using static System.Console;

namespace chp06.UsingOut
{
    class MainApp
    {
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;

            Divide(20, 3, out int c, out int d);

            WriteLine($"a:{a}, b:{b}, a/b:{c}, a%b:{d}");
        }
    }
}
