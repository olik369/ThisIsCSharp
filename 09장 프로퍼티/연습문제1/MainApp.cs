using System;
using static System.Console;

namespace 연습문제1
{
    class NameCard
    {
        public int age { get; set; }
        public string name { get; set; }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            NameCard MyCard = new NameCard()
            {
                age = 24,
                name = "동호"
            };

            WriteLine($"나이 : {MyCard.age}");
            WriteLine($"이름 : {MyCard.name}");
        }
    }
}
