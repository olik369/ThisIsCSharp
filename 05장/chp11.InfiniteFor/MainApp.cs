﻿using System;
using static System.Console;

namespace chp11.InfiniteFor
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (; ; )
                WriteLine(i++);
        }
    }
}
