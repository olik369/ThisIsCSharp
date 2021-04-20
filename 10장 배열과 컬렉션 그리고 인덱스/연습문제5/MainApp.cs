using System;
using static System.Console;
using System.Collections;

namespace 연습문제5
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht["회사"] = "Microsoft";
            ht["URL"] = "www.microsoft.com";

            WriteLine($"회사 : {ht["회사"]}");
            WriteLine($"URL : {ht["URL"]}");
        }
    }
}
