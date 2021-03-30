using System;

namespace Enum3
{
    class MainApp
    {
        enum DialogResult { YES = 10, NO, CANCEL, CONFIRM = 50, OK }    //숫자 지정이 가능하고 순서대로 할당됨

        static void Main(string[] args)
        {
            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);
        }
    }
}
