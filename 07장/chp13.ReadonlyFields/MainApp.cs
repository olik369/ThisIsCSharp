using System;
using static System.Console;

namespace chp13.ReadonlyFields
{
    class Configuration
    {
        private readonly int min;
        private readonly int max;

        public Configuration(int v1, int v2)
        {
            min = v1;
            max = v2;
        }

        public void ChangeMax(int newMax)
        {
            //생성자가 아닌곳에서 읽기전용필드를 초기화 하려고하면 컴파일 에러가 발생
            //max = newMax;
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Configuration c = new Configuration(100, 10);
        }
    }
}
