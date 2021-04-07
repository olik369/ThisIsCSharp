﻿using System;
using static System.Console;

namespace chp08.UsingParams
{
    class MainApp
    {
        static int Sum(params int[] args)
        {
            Write("Summing...");

            int sum = 0;

            foreach(int a in args)
            {
                Write($"{a} ");
                sum += a;
            }
            WriteLine("");
            return sum;
        }

        static void Main(string[] args)
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);

            WriteLine($"Sum : {sum}");
        }
    }
}
