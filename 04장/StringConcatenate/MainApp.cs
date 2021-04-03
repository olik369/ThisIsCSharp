using System;
using static System.Console;

namespace chp3.StringConcatenate
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string result = "123" + "456";  //string은 참조형이므로 연산과정에서 필연적으로 가비지 발생
            WriteLine(result);

            result = "Hello" + " " + "World!";
            WriteLine(result);
        }
    }
}
