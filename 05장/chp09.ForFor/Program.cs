using System;
using static System.Console;

namespace chp09.ForFor
{
    class MainApp
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }
        }
    }
}
