using System;

namespace BoxingUnboxing
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 123;
            object b = (object)a;   //a에 담긴 값을 박싱하여 힙에 저장
            int c = (int)b;         //b가 참조하는 값이면서 힙에 저장된 값을 언박싱하여 스택에 할당

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            double x = 3.141423;
            object y = (object)x;
            double z = (double)y;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
