using System;
using static System.Console;

namespace chp11.MethodHiding
{
    class Base
    {
        public void MyMethod()
        {
            WriteLine("Base.MyMethod()");
        }
    }

    class Derived : Base
    {
        //메소드 숨기기 키워드는 오버라이딩과 비슷해보이지만 다른것임
        //오버라이딩은 완전한 다형성을 표현할 수 있지만 new키워드는 그것이 불가능함
        public new void MyMethod()
        {
            WriteLine("Derived.MyMethod()");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Base baseObj = new Base();
            baseObj.MyMethod();

            Derived derivedObj = new Derived();
            derivedObj.MyMethod();

            Base baseOrDerived = new Derived();
            baseOrDerived.MyMethod();   //Base.MyMethod()를 호출 할것임
        }
    }
}
