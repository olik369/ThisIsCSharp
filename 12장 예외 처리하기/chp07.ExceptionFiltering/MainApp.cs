using System;
using static System.Console;

namespace chp07.ExceptionFiltering
{
    class FilterableException : Exception
    {
        public int ErrorNo { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            WriteLine("Enter Number Between 0~10");
            string input = ReadLine();
            try
            {
                int num = Convert.ToInt32(input);

                if (num < 0 || num > 10)
                    throw new FilterableException() { ErrorNo = num };
                else
                    WriteLine($"Output: {num}");
            }
            catch(FilterableException e)when (e.ErrorNo < 0)
            {
                WriteLine("Negative input is not allowed.");
            }
            catch(FilterableException e) when (e.ErrorNo > 10)
            {
                WriteLine("Too big number is not allowed.");
            }
        }
    }
}
