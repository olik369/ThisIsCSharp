using System;
using static System.Console;

namespace Nullable
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int? a = null;

            WriteLine(a.HasValue);  //a는 비어있으므로 false값을 도출할 것임!
            WriteLine(a != null);   //a는 비어있으므로 false값을 도출

            a = 3;

            WriteLine(a.HasValue);  //이제는 a에 값이 할당되었으므로 true값을 도출
            WriteLine(a != null);   //true!!
            WriteLine(a.Value);
        }
    }
}
