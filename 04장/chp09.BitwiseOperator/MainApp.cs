using System;
using static System.Console;

namespace chp09.BitwiseOperator
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p.138

            int a = 9;  // 0000_1001
            int b = 10; // 0000_1010

            WriteLine($"{a} & {b} : {a & b}");  // 0000_1000 = 8
            WriteLine($"{a} | {b} : {a | b}");  // 0000_1011 = 11
            WriteLine($"{a} ^ {b} : {a ^ b}");  // 0000_0011 = 3

            int c = 255;
            WriteLine($"~{c}(0x{c:X8}) : {~c}(0x{~c:X8})");
        }
    }
}
