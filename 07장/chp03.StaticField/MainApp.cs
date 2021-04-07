using System;
using static System.Console;

namespace chp03.StaticField
{
    class Global
    {
        public static int Count = 0;
    }

    class ClassA
    {
        public ClassA()
        {
            Global.Count++;
        }
    }

    class ClassB
    {
        public ClassB()
        {
            Global.Count++;
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            WriteLine($"Global.Count : {Global.Count}");

            new ClassA();   //ClassA 생성자 호출(호출하면서 글로벌 클래스의 Count를 증가시킴)
            new ClassA();
            new ClassB();
            new ClassB();

            WriteLine($"Global.Count : {Global.Count}");
        }
    }
}
