using System;
using static System.Console;

namespace 연습문제1
{
    class MainApp
    {
        static double Square(double num)
        {
            return num * num;
        }
        static void Main(string[] args)
        {
            Write("수를 입력하세요: ");
            string input = ReadLine();
            var number = double.Parse(input);

            var result = Square(number);

            WriteLine($"결과 : {result}");
        }
    }
}
