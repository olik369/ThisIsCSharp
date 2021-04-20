using System;
using static System.Console;
using System.Collections;

//Generic(일반화 프로그래밍), 메소드뒤에<>를 넣어서 다양한 데이터타입을 받을 수 있게 해줌!!
namespace chp01.CopyingArray
{
    class MainApp
    {
        //일반화 메소드
        static void CopyArray<T>(T[] source,T[] target)
        {
            for(int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = new int[source.Length];

            CopyArray<int>(source, target);

            foreach (var element in target)
                WriteLine(element);

            string[] source2 = { "하나", "둘", "셋", "넷", "다섯" };
            string[] target2 = new string[source2.Length];

            CopyArray<string>(source2, target2);

            foreach (var element in target2)
                WriteLine(element);
        }
    }
}
