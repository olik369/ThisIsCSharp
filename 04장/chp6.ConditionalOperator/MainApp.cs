using System;
using static System.Console;

namespace chp6.ConditionalOperator
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //조건연산자
            //변수 = 조건식 ? 참일때의 값 : 거짓일때의 값;
            var result = (10 % 2) == 0 ? "짝수" : "홀수";

            WriteLine(result);
        }
    }
}
