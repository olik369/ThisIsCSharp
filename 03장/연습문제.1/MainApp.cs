using System;
using static System.Console;

namespace 연습문제1
{
    class MainApp
    {
        static void Main(string[] args)
        {
            WriteLine("사각형의 너비를 입력하세요.");
            string width = ReadLine();

            WriteLine("사각형의 높이를 입력하세요.");
            string height = ReadLine();

            #region 사각형의 넓이 계산
            var space = int.Parse(width) * int.Parse(height);
            #endregion

            #region 출력하는 루틴
            WriteLine($"사각형의 넓이는 : {space}");
            #endregion
        }
    }
}
