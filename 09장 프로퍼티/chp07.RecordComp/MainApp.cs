using System;
using static System.Console;

namespace chp07.RecordComp
{
    class CTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }

    record RTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }
    class MainApp

    {
        static void Main(string[] args)
        {
            CTransaction trA = new CTransaction { From = "Alice", To = "Bob", Amount = 100 };
            CTransaction trB = new CTransaction { From = "Alice", To = "Bob", Amount = 100 };

            WriteLine(trA);
            WriteLine(trB);
            WriteLine($"trA equals to trB : {trA.Equals(trB)}");

            RTransaction tr1 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };
            RTransaction tr2 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };

            WriteLine(tr1);
            WriteLine(tr2);
            WriteLine($"tr1 equals to tr2 : {tr1.Equals(tr2)}");

            //클래스의 경우 따로 오버라이드해서 Equals메소드를 재정의 하지 않은 이상 원하는값이 안나옴
            //그러나, 레코드의 경우 필드값끼리 알아서 비교를 잘해줌 ㅎㅎ
        }
    }
}
