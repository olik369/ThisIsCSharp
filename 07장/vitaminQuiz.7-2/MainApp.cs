using System;
using static System.Console;
using MyExtension;

namespace MyExtension
{
    public static class StringExtension
    {
        public static string Append(this string src1, string src2)
        {
            string result = src1 + src2;

            return result;
        }
    }
}

namespace vitaminQuiz._7_2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            WriteLine(hello.Append(", World!"));
        }
    }
}