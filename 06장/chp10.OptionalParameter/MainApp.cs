using System;
using static System.Console;

namespace chp10.OptionalParameter
{
    class MainApp
    {
        static void PrintProfile(string name, string phone = "")
        {
            WriteLine($"Name:{name}, Phone:{phone}");
        }
        static void Main(string[] args)
        {
            PrintProfile("중근");
            PrintProfile("관순", "010-123-1234");
            PrintProfile(name: "봉길");
            PrintProfile(phone: "010-789-7890", name: "동주");
        }
    }
}
