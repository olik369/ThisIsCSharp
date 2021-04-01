﻿using System;
using static System.Console;

namespace StringSlice
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            WriteLine(greeting.Substring(0, 5));    //"Good"
            WriteLine(greeting.Substring(5));   //"morning"
            WriteLine();

            string[] arr = greeting.Split(new string[] { " " }, StringSplitOptions.None);
            WriteLine("Word Count : {0}", arr.Length);
            WriteLine("ABC{1}{0}", "DEF", "BCD");
            foreach (string element in arr)
            {
                WriteLine("{0}", element);
            }

        }
    }
}
