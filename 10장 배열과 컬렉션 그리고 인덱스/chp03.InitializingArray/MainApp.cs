using System;
using static System.Console;

namespace chp03.InitializingArray
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //배열 초기화 방법1
            string[] array1 = new string[3] { "안녕", "Hello", "Halo" };
            
            //배열 초기화 방법2
            string[] array2 = new string[] { "안녕", "Hello", "Halo" };
            
            //배열 초기화 방법3
            string[] array3 = { "안녕", "Hello", "Halo" };

            WriteLine("array1....");
            foreach (string greeting in array1)
                WriteLine($"{greeting}");
            
            WriteLine("\narray2....");
            foreach (string greeting in array2)
                WriteLine($"{greeting}");
            
            WriteLine("\narray3....");
            foreach (string greeting in array3)
                WriteLine($"{greeting}");
        }
    }
}
