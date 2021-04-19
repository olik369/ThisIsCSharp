using System;
using static System.Console;

namespace chp04.DerivedFromArray
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 30, 20, 7, 1 };
            WriteLine($"Type of array : {array.GetType()}");
            WriteLine($"Base type Of array : {array.GetType().BaseType}");
        }
    }
}
