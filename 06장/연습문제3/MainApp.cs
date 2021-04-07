using System;
using static System.Console;

namespace 연습문제3
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int resultA = 0;

            Plus(a, b, out resultA);

            WriteLine($"{a} + {b} = {resultA}");
            
            double x = 2.4;
            double y = 3.1;
            double resultB = 0;

            Plus(x, y, out resultB);

            WriteLine($"{x} + {y} = {resultB}");
        }

        public static void Plus(int a, int b, out int c)
        {
            c = a + b;
        }

        public static void Plus(double a, double b, out double c)
        {
            c = a + b;
        }
    }
}
