using System;
using static System.Console;

namespace UsingVar
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var a = 20; //var은 선언과 동시에 초기화를 반드시 해줘야함
            WriteLine("Type: {0}, Value: {1}", a.GetType(), a);

            var b = 3.1414213;
            WriteLine("Type: {0}, Value: {1}", b.GetType(), b);

            var c = "Hello, World!";
            WriteLine("Type: {0}, Value: {1}", c.GetType(), c);

            var d = new int[] { 10, 20, 30 };   //var로 배열도 선언가능!!
            Write("Type: {0}, Value: ", d.GetType());
            foreach (var e in d)
                Write("{0} ", e);

            WriteLine();
        }
    }
}
