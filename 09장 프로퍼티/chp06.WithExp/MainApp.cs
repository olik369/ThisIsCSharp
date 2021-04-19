using System;
using static System.Console;

//with를 이용해서 레코드 복사를 하는 방법
namespace chp06.WithExp
{
    //with키워드를 쓰기 위해서는 반드시 레코드 타입으로 선언해야함!!
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
            RTransaction tr1 = new RTransaction()
            {
                From = "Alice",
                To = "Bob",
                Amount = 100
            };
            RTransaction tr2 = tr1 with { To = "Charlie" };
            RTransaction tr3 = tr2 with { From = "Dave", Amount = 30 };

            WriteLine(tr1);
            WriteLine(tr2);
            WriteLine(tr3);
        }
    }
}
