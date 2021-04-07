using System;
using static System.Console;

namespace chp10.Overriding
{
    class ArmorSuite
    {
        public virtual void Initialize()
        {
            WriteLine("Armored");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()   //부모의 메소드를 재정의 하는것임
        {
            base.Initialize();
            WriteLine("Repulsor Rays Armed");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            WriteLine("Double-Barrel Cannons Armed");
            WriteLine("Micro-Rocket Launcher Armed");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            WriteLine("Creating ArmorSuite...");
            ArmorSuite armorsuite = new ArmorSuite();
            armorsuite.Initialize();

            WriteLine("\nCreating IronMan...");
            ArmorSuite ironman = new IronMan();
            ironman.Initialize();

            WriteLine("\nCreating WarMachine...");
            WarMachine warMachine = new WarMachine();
            warMachine.Initialize();

            /*
            WriteLine("\n다형성 실험");
            ArmorSuite armor = new IronMan();
            armor.Initialize();
             */
            //상속의 다운캐스팅 업캐스팅을 다시 봐야할듯;;
        }
    }
}
