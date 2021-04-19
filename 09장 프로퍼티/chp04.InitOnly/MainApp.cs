using System;
using static System.Console;

namespace chp04.InitOnly
{
    class Transaction
    {
        //Init을 통해 클래스의 readonly필드값과 같이 한번 선언 후 변경이 불가능하게 할 수 있음
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
            Transaction tr1 = new Transaction { From = "Alice", To = "Bob", Amount = 100 };
            Transaction tr2 = new Transaction { From = "Bob", To = "Charlie", Amount = 50 };
            Transaction tr3 = new Transaction { From = "Charlie", To = "Alice", Amount = 50 };
            
            //init으로 데이터를 받기때문에 한번 받고 나서는 새로운값으로 초기화 불가능!
            //tr1.Amount = 70;
            WriteLine(tr1);
            WriteLine(tr2);
            WriteLine(tr3);
        }
    }
}
