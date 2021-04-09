using System;
using static System.Console;

namespace chp03.MultiInterfaceInheritance
{
    interface IRunnable
    {
        void Run();
    }

    interface IFlyable
    {
        void Fly();
    }

    class FlyingCar : IRunnable, IFlyable
    {
        public void Run()
        {
            WriteLine("Run! Run!");
        }

        public void Fly()
        {
            WriteLine("Fly! Fly!");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runnable = car as IRunnable;  //굳이 명시적으로 형변환 할필요가 없지않나?
                                                    //어짜피 업캐스팅이 일어나는데??
                                                    //자식클래스 -> 부모클래스 형변환(업캐스팅)
            runnable.Run();

            IFlyable flyable = car as IFlyable;
            flyable.Fly();
        }
    }
}
