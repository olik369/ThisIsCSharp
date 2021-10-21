using static System.Console;

namespace ThisConstructor
{
    class MyClass
    {
        int a, b, c;

        public MyClass()
        {
            this.a = 5425;
            WriteLine("MyClass() 호출");
        }

        //여기서 this()는 위에 있는 MyClass() 생성자를 호출함!
        public MyClass(int b) : this()
        {
            this.b = b;
            WriteLine("MyClass(int b) 호출");
        }

        //여기서 this(int)는 MyClass(int) 생성자를 호출함
        public MyClass(int b, int c) : this(b)
        {
            this.c = c;
            WriteLine("MyClass(int b, int c) 호출");
        }

        public void PrintFields()
        {
            WriteLine($"a:{a}, b:{b}, c:{c}");
            WriteLine();
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.PrintFields();

            MyClass b = new MyClass(1);
            b.PrintFields();

            MyClass c = new MyClass(10, 20);
            c.PrintFields();
        }
    }
}