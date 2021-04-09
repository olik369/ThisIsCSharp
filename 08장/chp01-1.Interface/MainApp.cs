using System;
using static System.Console;
using System.IO;

//비타민 퀴즈 8-1
namespace chp01_1.Interface
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        //ILogger 인터페이스를 상속받았으므로 반드시 구현해야하는 메소드
        {
            WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
        }
    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        //ILogger 인터페이스를 상속받았으므로 반드시 구현해야하는 메소드
        {
            writer.WriteLine($"{DateTime.Now.ToShortTimeString()}, {message}");
        }
    }

    class ClimateMonitor
    {
        private ConsoleLogger logger;
        public ClimateMonitor(ConsoleLogger logger)
        {
            this.logger = logger;
        }

        public void start()
        {
            while (true)
            {
                Write("온도를 입력해주세요 : ");
                string temprature = ReadLine();
                if (temprature == "")
                    break;

                logger.WriteLog("현재 온도 : " + temprature);
            }
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            // ~ bin\Debug\net5.0 경로에 MyLog.txt파일이 생성되어 있음
            ClimateMonitor monitor = new ClimateMonitor(
                new ConsoleLogger());

            monitor.start();
        }
    }
}
