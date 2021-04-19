using System;
using static System.Console;

namespace chp06.Slice
{
    class MainApp
    {
        static void PrintArray(System.Array array)
        {
            foreach (var e in array)
                Write(e);
            WriteLine();
        }
        static void Main(string[] args)
        {
            //ASCI코드 상에서 Z = 90 , A = 65임
            char[] array = new char['Z' - 'A' + 1];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = (char)('A' + i);
            }

            PrintArray(array[..]);  //0번째부터 마지막까지
            PrintArray(array[..^1]);    //어떻게 될지 궁금해서 써봄
            PrintArray(array[5..]); //5번 인덱스부터 끝까지

            Range range_5_10 = 5..10;   //5번부터 (10-1)번까지
            PrintArray(array[range_5_10]);

            //^숫자 : "Array.Length - 숫자" 로 이해하기!!
            Index last = ^0;
            Range range_5_last = 5..last;
            PrintArray(array[range_5_last]);

            PrintArray(array[^4..^1]);
        }
    }
}
