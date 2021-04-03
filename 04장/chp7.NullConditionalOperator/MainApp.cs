using System.Collections;
using static System.Console;

namespace chp7.NullConditionalOperator
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // p.128

            // 객체?.멤버
            // ?.연산자는 객체의 멤버에 접근하기전에 null이 아닌지 확인하는 연산자
            // 1. 만약 객체가 null이 아니라면 멤버에 접근할 수 있음
            // 2. 만약 객체가 null이면 null을 반환함
            ArrayList a = null;
            a?.Add("야구");   // a?.가 null을 반환하므로 Add() 메소드는 호출되지 않음
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");

            a = new ArrayList();    //a는 이제 더이상 null이 아닙니다.
            a?.Add("야구");
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");
        }
    }
}
