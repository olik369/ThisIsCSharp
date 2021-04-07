using System;
using static System.Console;

namespace chp06.ThisConstructor
{
    class MyClass
    {
        int a, b, c;

        public MyClass()
        {
            this.a = 5425;
            WriteLine("MyClass()");
        }

        public MyClass(int b) : this()  //this()로 MyClass()호출
        {
            this.b = b;
            WriteLine($"MyClass({b})");
        }

        public MyClass(int b, int c) : this(b)  //this()로 MyClass(int)호출
        {
            this.c = c;
            WriteLine($"MyClass({b}, {c})");
        }

        public void PrintFields()
        {
            WriteLine($"a:{a}, b:{b}, c:{c}");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.PrintFields();
            WriteLine();

            MyClass b = new MyClass(1);
            b.PrintFields();
            WriteLine();

            MyClass c = new MyClass(10, 20);
            c.PrintFields();
        }
    }
}
