using static System.Console;

namespace Constructor
{
    class Cat
    {
        // 필드
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

        //C#에서는 되도록 소멸자는 구현하지 않는것이 좋음!
        ~Cat()
        {
            WriteLine($"잘가~");
        }

        public void Meow()
        {
            WriteLine($"{Name} : 야옹~");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat(_Name: "키티", _Color: "하얀색");
            kitty.Meow();
            WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            WriteLine($"{nero.Name} : {nero.Color}");
        }

    }
}