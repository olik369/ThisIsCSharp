using System;
using static System.Console;

namespace chp05.SwitchExp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p.181

            WriteLine("점수를 입력하세요");

            //둘의 차이를 모르겠음;;
            var score = Convert.ToInt32(ReadLine());
            //var score = int.Parse(ReadLine());
            
            WriteLine("재수강인가요? (y/n)");
            var line = ReadLine();
            bool repeated = ((line == "y") ? true : false);

            var grade = (int)(Math.Truncate(score / 10.0) * 10) switch
            {
                90 when repeated == true => "B+",
                90 => "A",
                80 => "B",
                70 => "C",
                60 => "D",
                _ => "F"

            };

            WriteLine($"학점 : {grade}");
        }
    }
}
