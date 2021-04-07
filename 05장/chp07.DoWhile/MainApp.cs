using System;
using static System.Console;

namespace chp07.DoWhile
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int i = 10;

            do
            {
                WriteLine("a) i : {0}", i--);
            }
            while (i > 0);

            do
            {
                WriteLine("b) i : {0}", i--);   //이미 i가 0이지만 do문을 무조건 한번 실행함
            }
            while (i > 0);
        }
    }
}
