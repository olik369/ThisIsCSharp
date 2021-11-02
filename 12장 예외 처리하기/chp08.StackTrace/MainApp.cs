using System;
using static System.Console;

//try~catch를 이용한 예외처리의 이점 중 하나는 에러 위치를 알려줌
namespace chp08.StackTrace
{
    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 1;
                WriteLine(3 / --a); //이곳에서 에러가 발생했다는 것을 알려줌(디버깅 용이)
            }
            catch(DivideByZeroException e)
            {
                WriteLine(e.StackTrace);
            }
        }
    }
}
