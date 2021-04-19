using System;
using static System.Console;

namespace chp08.AnonymousType
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var a = new { Name = "김동호", Age = 123 };
            WriteLine($"Name : {a.Name}, Age : {a.Age}");

            var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };

            Write($"Subject : {b.Subject}, Scores : ");
            foreach (var score in b.Scores)
                Write($"{score} ");

            WriteLine();
        }
    }
}
