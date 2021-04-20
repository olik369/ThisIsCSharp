using System;
using static System.Console;

namespace chp09.JaggedArray
{
    class MainApp
    {
        //가변배열
        //int[][] array = new int[3][];
        //여기서 3은 array라는 가변배열이 갖고 있을수 있는 배열의 갯수(용량)
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 10, 20, 30 };
            jagged[2] = new int[] { 100, 200 };

            foreach(int[] arr in jagged)
            {
                Write($"Length : {arr.Length}, ");
                foreach(var e in arr)
                {
                    Write($"{e} ");
                }
                WriteLine("");
            }

            WriteLine("");

            int[][] jagged2 = new int[2][] {
                new int[]{1000,2000},
                new int[4]{6,7,8,9} };

            foreach(var arr in jagged2)
            {
                Write($"Length : {arr.Length}, ");
                foreach(int e in arr)
                {
                    Write($"{e} ");
                }
                WriteLine();
            }
        }
    }
}
