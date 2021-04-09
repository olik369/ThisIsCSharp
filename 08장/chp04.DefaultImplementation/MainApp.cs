using System;
using static System.Console;

namespace chp04.DefaultImplementation
{
    interface ILogger   //이 인터페이스를 상속받은 파생클래스가 많이 생겼을때 레거시라고 함
    {
        void WriteLog(string message);

        //상속받은 클래스에 영향을 안미치면서 추가코드를 넣으려면
        //아래처럼 기본 구현메소드를 작성하면됨!!
        void WriteError(string error)
        {
            WriteLog($"Error : {error}");
        }
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();   //업캐스팅
            logger.WriteLog("System Up");
            logger.WriteError("System Fail");

            ConsoleLogger clogger = new ConsoleLogger();
            clogger.WriteLog("System Up");

            //오버라이드로 WriteError를 구현하지 않는한 무조건 컴파일 에러가 발생
            //근데 ConsoleLogger클래스에서 오버라이딩이 안되네;; 왜 안되는지 모르겠음
            //clogger.WriteError("System Fail");
        }
    }
}
