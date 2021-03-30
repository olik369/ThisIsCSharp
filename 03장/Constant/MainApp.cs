using System;

namespace Constant
{
    class MainApp
    {
        static void Main(string[] args)
        {
            const int MAX_INT = int.MaxValue;
            const int MIN_INT = int.MinValue;

            Console.WriteLine(MAX_INT);
            Console.WriteLine(MIN_INT);
        }
    }
}