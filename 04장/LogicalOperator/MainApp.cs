using System;
using static System.Console;

namespace chp5.LogicalOperator
{
    class MainApp
    {
        static void Main(string[] args)
        {
            WriteLine("Testing && ....");
            WriteLine($"1 > 0 && 4 < 5 : {1 > 0 && 4 < 5}");    //True
            WriteLine($"1 > 0 && 4 > 5 : {1 > 0 && 4 > 5}");    //False
            WriteLine($"1 == 0 && 4 > 5 : {1 == 0 && 4 > 5}");  //False
            WriteLine($"1 == 0 && 4 < 5 : {1 == 0 && 4 < 5}");  //False

            WriteLine("\nTesting || ....");
            WriteLine($"1 > 0 || 4 < 5 : {1 > 0 || 4 < 5}");    //True
            WriteLine($"1 > 0 || 4 > 5 : {1 > 0 || 4 > 5}");    //True
            WriteLine($"1 == 0 || 4 > 5 : {1 == 0 || 4 > 5}");  //False
            WriteLine($"1 == 0 || 4 < 5 : {1 == 0 || 4 < 5}");  //True

            WriteLine("\nTesting !....");
            WriteLine($"!True : {!true}");  //False
            WriteLine($"!False : {!false}");//True
        }
    }
}
