using System;
using static System.Console;

namespace chp8.ShiftOperator
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p.134
            WriteLine("Testing <<...");

            int a = 1;
            WriteLine($"a      : {a:D5} (0x{a:X8})");
            WriteLine($"a << 1 : {a << 1:D5} (0x{a << 1:X8})");
            WriteLine($"a << 2 : {a << 2:D5} (0x{a << 2:X8})");
            WriteLine($"a << 5 : {a << 5:D5} (0x{a << 5:X8})");

            WriteLine("\nTesting >>...");

            int b = 255;
            WriteLine($"b      : {b:D5} (0x{b:x8})");
            WriteLine($"b >> 1 : {b >> 1:D5} (0x{b >> 1:X8})");
            WriteLine($"b >> 2 : {b >> 2:D5} (0x{b >> 2:X8})");
            WriteLine($"b >> 5 : {b >> 5:D5} (0x{b >> 5:X8})");

            WriteLine("\nTesting >> 2...");
            
            int c = -255;
            WriteLine($"c      : {c:D5} (0x{c:X8})");
            WriteLine($"c >> 1 : {c >> 1:D5} (0x{c >> 1:X8})");
            WriteLine($"c >> 2 : {c >> 2:D5} (0x{c >> 2:X8})");
            WriteLine($"c >> 5 : {c >> 5:D5} (0x{c >> 5:X8})");
        }
    }
}
