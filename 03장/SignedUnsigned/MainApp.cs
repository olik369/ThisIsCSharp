using System;
using static System.Console;

namespace SignedUnsigned
{
    class MainApp
    {
        static void Main(string[] args)
        {
            byte a = 255;       //255 = 0b1111_1111
            sbyte b = (sbyte)a; //-1은 1을 2의보수를 통해 얻을 수 있음
                                //1 => 0000_0001 => 1111_1110 => 1111_1111 
                                //그래서 byte에서는 255였던 수가 sbyte에서는 -1을 의미함

            WriteLine($"a = {a}");
            WriteLine($"b = {b}");
        }
    }
}
