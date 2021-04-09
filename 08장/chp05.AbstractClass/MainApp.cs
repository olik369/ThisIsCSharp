using System;
using static System.Console;

namespace chp05.AbstractClass
{
    //추상클래스는 자기 자신을 객체로 생성하지 못함!
    //즉, 추상클래스 = 인터페이스의 기능 + 일반클래스의 기능 + 처음 클래스를 만든 프로그래머의
    //의도를 함축적으로 표현할 수 있는 기능
    abstract class AbstractBase
    {
        //추상클래스도 기존클래스와 마찬가지로 메소드를 선언할 수 있음
        protected void PrivateMethodA()
        {
            WriteLine("AbstractBase.PrivateMethodA()");
        }

        public void PublicMethodA()
        {
            WriteLine("AbstractBase.PublicMethodA()");
        }

        //추상메소드는 프로그래머에게 강제적으로 이 메소드를 구현하도록 요구하게 함
        //이는 인터페이스의 역할과 같음
        //그리고 추상메소드는 인터페이스의 역할을 하는곳이므로 반드시 접근제어자를
        //입력해야하고 private수준이 절대로 될수 없음!!!!
        public abstract void AbstractMethodA();
    }

    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            WriteLine("Derived.AbstractMethodA()");
            PrivateMethodA();   //protected기 때문에 상속받은 클래스에서는 접근 가능
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();  //Derived.Abs~ 출력, Abs~.PrivateMethod 출력?!
            obj.PublicMethodA();    //Abs.Publ~ 출력
        }
    }
}
