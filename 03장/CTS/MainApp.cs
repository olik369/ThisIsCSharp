using System;
using static System.Console;

namespace CTS
{
    class MainApp
    {
        static void Main(string[] args)
        {
            System.Int32 a = 123;
            int b = 456;

            WriteLine("a type: {0}, value: {1}", a.GetType().ToString(), a);
            WriteLine("b type: {0}, value: {1}", b.GetType().ToString(), b);

            System.String c = "abc";
            string d = "def";

            WriteLine("c type: {0}, value: {1}", c.GetType().ToString(), c);
            WriteLine("d type: {0}, value: {1}", d.GetType().ToString(), d);
        }
    }
}
