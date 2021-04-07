using System;
using static System.Console;

namespace chp09.NamedParameter
{
    class MainApp
    {
        static void PrintProfile(string name, string phone)
        {
            WriteLine($"Name:{name}, Phone:{phone}");
        }
        static void Main(string[] args)
        {
            PrintProfile(name: "박찬호", phone: "010-123-1234");
            PrintProfile(phone: "010-987-9876", name: "박지성");   //명명된 인수를 이용하면 인수순서를 바꿀 수 있음
            PrintProfile("박세리", "010-222-2222");
            PrintProfile("박상현", phone: "010-567-5678");
        }
    }
}
