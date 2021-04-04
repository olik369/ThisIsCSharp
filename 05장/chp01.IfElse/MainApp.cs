using System;
using static System.Console;

namespace chp01.IfElse
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Write("숫자를 입력하세요 : ");

            var input = ReadLine();
            var number = Int32.Parse(input);

            if (number < 0)
                WriteLine("음수");
            else if (number > 0)
                WriteLine("양수");
            else
                WriteLine("0");

            if (number % 2 == 0)
                WriteLine("짝수");
            else
                WriteLine("홀수");
        }
    }
}
