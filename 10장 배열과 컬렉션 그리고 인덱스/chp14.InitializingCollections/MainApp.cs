using System;
using System.Collections;
using static System.Console;

namespace chp14.InitializingCollections
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] arr = { 123, 456, 789 };

            ArrayList list = new ArrayList(arr);
            foreach (var item in list)
                WriteLine($"ArrayList : {item}");
            WriteLine();

            Stack stack = new Stack(arr);
            foreach (var item in stack)
                WriteLine($"Stack : {item}");
            WriteLine();

            Queue queue = new Queue(arr);
            foreach (var item in queue)
                WriteLine($"Queue : {item}");
            WriteLine();

            //Stack과 Queue는 컬렉션 초기자를 쓸수가 없음!!
            //컬렉션초기자는 Add() 메소드를 구현하는 컬렉션만 지원하기때문!!
            ArrayList list2 = new ArrayList() { 11, 22, 33 };
            foreach (var item in list2)
                WriteLine($"ArrayList2 : {item}");
            WriteLine();
        }
    }
}
