using static System.Console;
using MyExtension;

namespace MyExtension
{
    //"public" "static" "class" 클래스이름
    public static class IntegerExtension
    {
        //"public" "static" 반환형식 메소드이름(this 대상형식 식별자, 매개변수 목록)
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for(int i = 1; i < exponent; i++)
            {
                result = result * myInt;
            }
            return result;
        }
    }
}

namespace ExtensionMethod
{
    class MainApp
    {
        static void Main(string[] args)
        {
            WriteLine($"3^2 : {3.Square()}");
            WriteLine($"3^4 : {3.Power(4)}");
            WriteLine($"2^10 : {2.Power(10)}");
        }
    }
}