using System;
using static System.Console;

namespace chp4.RelationalOperator
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //논리연산자의 결과값은 bool타입으로 나옴(당연?)
            WriteLine($"3 > 4 : {3 > 4}");      //false
            WriteLine($"3 >= 4 : {3 >= 4}");    //false
            WriteLine($"3 < 4 : {3 < 4}");      //true
            WriteLine($"3 <= 4 : {3 <= 4}");    //true
            WriteLine($"3 == 4 : {3 == 4}");    //false
            WriteLine($"3 != 4 : {3 != 4}");    //true
        }
    }
}
