using System;
using static System.Console;

namespace chp15.PartialClass
{
    partial class MyClass
    {
        public void Method1()
        {
            WriteLine("Method1");
        }

        public void Method2()
        {
            WriteLine("Method2");
        }
    }

    // 분할 되었지만 하나로 취급해서 컴파일 하기때문에 합쳐져 있는것처럼 쓰는것 가능
    partial  class MyClass
    {
        public void Method3()
        {
            WriteLine("Method3");
        }

        public void Method4()
        {
            WriteLine("Method4");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Method1();
            obj.Method2();
            obj.Method3();
            obj.Method4();
        }
    }
}
