using System;
using static System.Console;

namespace chp02.Constructor
{
    class Cat
    {
        public string Name;
        public string Color;

        public Cat()
        {
            Name = "";
            Color = "";
        }

        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }

        ~Cat()
        {
            WriteLine($"{Name} : 잘가");
        }

        public void Meow()
        {
            WriteLine($"{Name} : 야옹");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat("키티", "하얀색");
            kitty.Meow();
            WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}
