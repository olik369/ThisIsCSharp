using System;
using static System.Console;

namespace chp05.Record
{
    //레코드 타입을 통해 참조타입과 값타입의 이점을 모두 취할 수 있음
    //1. 연산에 필요한 비용이 참조타입처럼 매우 적음
    //2. DeepCopy와 같이 값타입이 유리한 구조일때는 값타입처럼 대입할 수 있음
    //3. Equals와 같은 메소드를 굳이 구현하지 않아도 컴파일러가 알아서 비교해줌
    //cf)클래스의 경우 Equals를 직접 구현하여 필드값이 동일한지 비교해야됨!!
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
            RTransaction tr1 = new RTransaction
            {
                From = "Alice",
                To = "Bob",
                Amount = 100
            };

            RTransaction tr2 = new RTransaction
            {
                From = "Alice",
                To = "Charlie",
                Amount = 100
            };

            WriteLine(tr1);
            WriteLine(tr2);
        }
    }
}
