﻿using System;
using static System.Console;

namespace chp21.PositionalPattern
{
    class MainApp
    {
        private static double GetDiscountRate(object client)
        {
            return client switch    //switch식을 사용했기에 굉장히 코드가 간결해짐
            {
                ("학생", int n) when n < 18 => 0.2,   //학생 & 18세 미만
                ("학생", _) => 0.1,                   //학생 & 18세 이상
                ("일반", int n) when n < 18 => 0.1,   //일반 & 18세 미만
                ("일반", _) => 0.05,                  //일반 & 18세 이상
                _ => 0
            };
        }
        static void Main(string[] args)
        {
            // 간단하게 구조체를 만들때는 튜플을 이용하기!!
            var alice   = (job: "학생", age: 17);
            var bob     = (job: "학생", age: 23);
            var charlie = (job: "일반", age: 15);
            var dave    = (job: "일반", age: 21);

            WriteLine($"alice   : {GetDiscountRate(alice)}");
            WriteLine($"bob     : {GetDiscountRate(bob)}");
            WriteLine($"charlie : {GetDiscountRate(charlie)}");
            WriteLine($"dave    : {GetDiscountRate(dave)}");
        }
    }
}
