using System;
using static System.Console;

namespace chp10.ForEach
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p.171

            int[] arr = new int[] { 0, 1, 2, 3, 4 };    //배열선언
            int i = 0;

            //foreach문은 배열이나 컬렉션을 순회하며 차례대로 접근함
            foreach(int e in arr)
            {
                WriteLine($"arr[{i++}] = {e}");
            }
        }
    }
}
