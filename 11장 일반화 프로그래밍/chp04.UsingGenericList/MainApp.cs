﻿using System;
using System.Collections.Generic;
using static System.Console;

namespace chp04.UsingGenericList
{
    class MainApp
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for(int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            foreach(int element in list)
            {
                Write($"{element} ");
            }
            WriteLine();

            list.RemoveAt(2);

            foreach(int element in list)
            {
                Write($"{element} ");
            }
            WriteLine();

            list.Insert(2, 2);

            foreach(int element in list)
            {
                Write($"{element} ");
            }
            WriteLine();
        }
    }
}
