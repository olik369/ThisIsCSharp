﻿using System;
using System.Collections;
using static System.Console;

namespace chp10.UsingList
{
    class MainApp
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for(int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            foreach (object obj in list)
                Write($"{obj} ");
            WriteLine();

            list.RemoveAt(2);

            foreach (object obj in list)
                Write($"{obj} ");
            WriteLine();

            list.Insert(2, 2);

            foreach (object obj in list)
                Write($"{obj} ");
            WriteLine();

            list.Add("abc");
            list.Add("def");

            for(int i = 0; i < list.Count; i++)
            {
                Write($"{list[i]} ");
            }
            WriteLine();
        }
    }
}
