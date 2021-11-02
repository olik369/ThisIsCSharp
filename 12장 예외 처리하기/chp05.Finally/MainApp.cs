using System;
using static System.Console;
using static System.Convert;

namespace chp05.Finally
{
    class MainApp
    {
        static int Divide(int dividend, int divisor)
        {
            try
            {
                WriteLine("Divide() 시작");
                return dividend / divisor;
            }
            catch(DivideByZeroException e)
            {
                WriteLine($"Divide() 예외 발생");
                throw e;
            }
            finally
            {
                WriteLine("Divide() 끝");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Write("제수를 입력하세요. : ");
                string temp = ReadLine();
                int dividend = ToInt32(temp);

                Write("피제수를 입력하세요. : ");
                temp = ReadLine();
                int divisor = ToInt32(temp);

                WriteLine($"{dividend}/{divisor} = {Divide(dividend, divisor)}");
            }
            catch(FormatException e)
            {
                WriteLine("에러 : " + e.Message);
            }
            catch(DivideByZeroException e)
            {
                WriteLine($"에러 : {e.Message}");
            }
            finally
            {
                WriteLine("프로그램을 종료합니다.");
            }
        }
    }
}
