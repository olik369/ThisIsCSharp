using static System.Console;

namespace UsingOut
{
    class MainApp
    {
        static void Divide(int a, int b, out int quotient,out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;
            //int c, d;
            //미리 선언 안해도 됨!!

            Divide(a, b, out int c, out int d);
            WriteLine($"a : {a}, b : {b}, a / b : {c}, a % b : {d}");
        }
    }
}