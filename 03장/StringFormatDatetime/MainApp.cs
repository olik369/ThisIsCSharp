using System;
using static System.Console;
using System.Globalization;

namespace StringFormatDatetime
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var dt = new DateTime(2018, 11, 3, 23, 18, 22);
            DateTime dt1 = new DateTime(2021, 4, 2, 21, 21, 15);
            WriteLine("한국식으로 시간 표현");
            WriteLine($"{dt}");
            WriteLine($"12시간 형식 :{dt:yyyy-MM-dd tt hh:mm:ss (ddd)}");
            WriteLine($"24시간 형식 :{dt:yyyy-MM-dd tt HH:mm:ss (dddd)}");

            CultureInfo ciKo = new CultureInfo("ko-KR");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciKo));
            //WriteLine($"{dt1.ToString("yyyy-MM-dd tt hh:mm:ss (dddd)", ciKo)}");

            var ciEn = new CultureInfo("en-US");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciEn));
            WriteLine(dt.ToString(ciEn));
        }
    }
}
