using System;

namespace Overflow
{
    class MainApp
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue; //a는 uint의 최댓값을 할당받음

            Console.WriteLine($"a = {a}");

            a = a + 1;              //overflow가 발생!!

            Console.WriteLine($"a = {a}");

            int b = int.MaxValue;

            b = b + 1;              //overflow가 발생하고 int.MinValue가 출력될것임!

            Console.WriteLine($"b = {b}");
        }
    }
}
