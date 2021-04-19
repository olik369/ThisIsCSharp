using System;
using static System.Console;

namespace 연습문제2
{
    //무명형식 이용하기!!
    class MainApp
    {
        static void Main(string[] args)
        {
            var nameCard = new { Name = "박상현", Age = 17 };
            WriteLine($"이름 : {nameCard.Name}, 나이 : {nameCard.Age}");

            var complex = new { Real = 3, Imaginary = -12 };
            WriteLine($"Real : {complex.Real}, Imaginary : {complex.Imaginary}");
        }
    }
}
