using System;
using static System.Console;

namespace chp02.IfIf
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Write("숫자를 입력하세요 : ");

            var input = ReadLine();
            var number = Int32.Parse(input);

            if(number > 0)
            {
                if (number % 2 == 0)
                    WriteLine("0보다 큰 짝수");
                else
                    WriteLine("0보다 큰 홀수");
            }
            else
            {
                WriteLine("0보다 작거나 같은 수");
            }

        }
    }
}
