using System;
using static System.Console;

namespace chp20.Tuple
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //명명되지 않은 튜플
            WriteLine("------명명되지 않은 튜플------");
            var a = ("슈퍼맨", 9999);
            WriteLine($"{a.Item1},{a.Item2}");  //명명되지 않은 튜플은 기본적으로 
                                                //Item1,2,3 등의 필드이름으로 저장됨
            //명명된 튜플
            WriteLine("------명명된 튜플------");
            var b = (Name: "김동호", Age: 17); //명명된 인수처럼 호출!
            WriteLine($"{b.Name}, {b.Age}");

            //분해
            WriteLine("------분해1------");
            var (name, age) = b;
            WriteLine($"{name}, {age}");

            //분해2
            WriteLine("------분해2------");
            var (name2, age2) = ("홍길동", 35);
            WriteLine($"{name2}, {age2}");

            //명명된 튜플 = 명명되지 않은 튜플
            WriteLine("------명명된 튜플 = 명명되지 않은 튜플------");
            b = a;
            WriteLine($"{b.Name}, {b.Age}");    //출력 : 슈퍼맨, 9999
        }
    }
}
