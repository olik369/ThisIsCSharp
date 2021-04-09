using System;
using static System.Console;

namespace chp03_1.MultiInterfaceInheritance
{
    interface IRunnable
    {
        void Run();
    }

    interface IFlyable
    {
        void Fly();
    }

    class Car : IRunnable
    {
        public void Run()
        {
            WriteLine("Run! Run!");
        }
    }

    class Plane : IFlyable
    {
        public void Fly()
        {
            WriteLine("Fly! Fly!");
        }
    }

    class FlyingCar : IRunnable, IFlyable
    {
        // 일반적으로는 아래 주석처리한것으로 인터페이스 다중상속의 구현부를 선언함
        /*
        public void Run()
        {
            WriteLine("Run~ Run~");
        }

        public void Fly()
        {
            WriteLine("Fly~ Fly~");
        }
         */

        // C#에서는 클래스의 다중상속을 절대 지원하지 않음!!
        // 아래 코드는 "포함" 이라는 기법을 통해 C++의 다중상속을 흉내내고 있음
        Car car = new Car();
        Plane plane = new Plane();

        public void Run()
        {
            car.Run();
        }

        public void Fly()
        {
            plane.Fly();
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            FlyingCar flyingcar = new FlyingCar();
            flyingcar.Fly();
            flyingcar.Run();
        }
    }
}
