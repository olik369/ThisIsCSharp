using System;
using static System.Console;

namespace chp11.NullCoalescing
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p.142
            int? num = null;
            WriteLine($"{num ?? 0}");

            num = 99;
            WriteLine($"{num ?? 0}");

            string str = null;
            WriteLine($"{str ?? "Default"}");   //str이 null이므로 Default할당 해줌

            str = "Specific";
            WriteLine($"{str ?? "Default"}");
        }
    }
}
