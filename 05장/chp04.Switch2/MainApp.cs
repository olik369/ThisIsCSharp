using System;
using static System.Console;

namespace chp04.Switch2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            object obj = null;
            
            string s = ReadLine();
            if (int.TryParse(s, out int out_i))
                obj = out_i;
            else if (float.TryParse(s, out float out_f))
                obj = out_f;
            else
                obj = s;

            #region 예제swtich~case문
            //switch (obj)
            //{
            //    case int i:
            //        WriteLine($"{i}는 int 형식입니다.");
            //        break;
            //    case float f:
            //        WriteLine($"{f}는 float 형식입니다.");
            //        break;
            //    default:
            //        Write($"{obj}(은)는 모르는 형식입니다.");
            //        break;
            //}
            #endregion

            #region 연습switch~case문
            switch (obj)
            {
                case int i:
                    WriteLine($"{obj}는 int형입니다.");
                    break;
                case float f when f >= 0:
                    WriteLine($"{obj}는 0보다 크거나 같은 float형입니다.");
                    break;
                case float f:
                    WriteLine($"{obj}는 0보다 작은 float형입니다.");
                    break;
                default:
                    WriteLine($"{obj}는 알 수 없는 데이터형입니다.");
                    break;
            }
            #endregion
        }
    }
}
