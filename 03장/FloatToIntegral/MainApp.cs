using System;

namespace FloatToIntegral
{
    class MainApp
    {
        static void Main(string[] args)
        {
            float a = 0.9f;
            int b = (int)a;
            Console.WriteLine(b);

            float c = 1.1f;
            int d = (int)c;         //float에서 int로의 변환은 소수점을 단순히 버리는 변환이 일어남
            Console.WriteLine(d);
        }
    }
}
