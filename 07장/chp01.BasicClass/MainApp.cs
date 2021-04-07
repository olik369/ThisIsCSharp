using System;
using static System.Console;

namespace chp01.BasicClass
{
    class Cat   //클래스 = 설계도
    {
        //필드
        public string Name;
        public string Color;

        //메소드
        public void Meow()
        {
            WriteLine($"{Name} : 야옹");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();  //클래스 인스턴스(객체) = new 생성자
            kitty.Color = "하얀색";
            kitty.Name = "키티";
            kitty.Meow();
            WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat();
            nero.Color = "검은색";
            nero.Name = "네로";
            nero.Meow();
            WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}
