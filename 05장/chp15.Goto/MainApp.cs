using System;
using static System.Console;

namespace chp15.Goto
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Write("종료 조건(숫자)을 입력하세요 : ");

            var input = ReadLine();
            int input_number;
            //var input_number = Convert.ToInt32(input);
            var success = Int32.TryParse(input, out input_number);

            var exit_number = 0;

            for(int i = 0; i< 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    for(int k = 0; k < 3; k++)
                    {
                        if (exit_number++ == input_number)
                            goto EXIT_FOR;

                        WriteLine(exit_number);
                    }
                }
            }

            goto EXIT_PROGRAM;

        EXIT_FOR:
            WriteLine("\nExit nested for...");

        EXIT_PROGRAM:
            WriteLine("Exit program");
        }
    }
}
