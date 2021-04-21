using System;
using System.Collections.Generic;
using static System.Console;

namespace chp06.UsingGenericStack
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
            {
                WriteLine(stack.Pop());
            }
        }
    }
}
