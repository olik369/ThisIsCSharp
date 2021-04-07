using System;
using static System.Console;

namespace chp14.Continue
{
    class MainApp
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    continue;

                WriteLine($"{i} : 홀수");
            }
        }
    }
}
