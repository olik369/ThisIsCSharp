using System;
using static System.Console;

namespace 연습문제
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            try
            {
                for(int i = 0; i < 11; i++)
                {
                    WriteLine(arr[i]);
                }
            }
            catch(IndexOutOfRangeException e)
            {
                WriteLine(e.Message);
                WriteLine(e.StackTrace);
            }
        }
    }
}
