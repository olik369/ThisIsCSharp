using System;
using static System.Console;

namespace chp08.Inheritance
{
    class Base
    {
        protected string Name;
        public Base(string Name)
        {
            this.Name = Name;
            WriteLine($"{this.Name}.Base()");
        }

        ~Base()
        {
            WriteLine($"{this.Name}.~Base()");
        }

        public void BaseMethod()
        {
            WriteLine($"{Name}.BaseMethod()");
        }
    }

    class Derived : Base
    {
        public Derived(string Name) : base(Name)
        {
            WriteLine($"{this.Name}.Derived()");
        }

        ~Derived()
        {
            WriteLine($"{this.Name}.~Derived()");
        }

        public void DerivedMethod()
        {
            WriteLine($"{Name}.DerivedMethod()");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");
            a.BaseMethod();

            Derived b = new Derived("b");   //자식 클래스의 인스턴스가 생성될때 
                                            //부모클래스의 생성자가 먼저 호출된 후 
                                            //자식클래스의 생성자가 호출됨
            b.BaseMethod();         //Base클래스에서 상속받았기에 BaseMethod사용 가능
            b.DerivedMethod();
        }
    }
}
