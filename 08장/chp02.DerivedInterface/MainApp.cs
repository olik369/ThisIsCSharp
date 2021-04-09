using System;
using static System.Console;

namespace chp02.DerivedInterface
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params Object[] args);
    }

    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string message)
        {
            WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
        }

        public void WriteLog(string format, params Object[] args)
        {
            string message = String.Format(format, args);
            WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            IFormattableLogger logger = new ConsoleLogger2();
            //ILogger의 메소드
            logger.WriteLog("The world is not flat.");
            //IFormattableLogger의 메소드
            logger.WriteLog($"{1} + {1} = {2}");
            logger.WriteLog("{0} + {1} = {2}", 1, 3, 4);
        }
    }
}
