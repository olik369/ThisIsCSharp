using System;
using static System.Console;

namespace chp19.ReadonlyMethod
{
    struct ACSetting
    {
        public double currentInCelsius; // 현재 온도(섭씨)
        public double target;           // 희망 온도

        public readonly double GetFahrenheit()
        {
            // 프로그래머의 실수로 구조체내의 필드값을 변경하는 것을 방지하기 위해
            // readonly를 사용해서 막은 것임 아래와 같이 필드값을 변경하는 코드를
            // 선언하면 컴파일 단계에서 에러를 띄움
            //target = currentInCelsius * 1.8 + 32;
            //return target;
            double currentInFahrenheit = currentInCelsius * 1.8 + 32;
            return currentInFahrenheit;
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;

            WriteLine($"{acs.GetFahrenheit()}");
            WriteLine($"{acs.target}");
        }
    }
}
