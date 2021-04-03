using System;
using static System.Console;
namespace chp2.IncDecOperator
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //컴파일 하지 않아도 값이 어떻게 나올지 예상할 수 있어야 함!!
            int a = 10;
            WriteLine(a++); //10
            WriteLine(++a); //12

            WriteLine(a--); //12
            WriteLine(--a); //10
        }
    }
}
