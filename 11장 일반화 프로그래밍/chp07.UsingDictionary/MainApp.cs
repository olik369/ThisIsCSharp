using System;
using System.Collections.Generic;
using static System.Console;

namespace chp07.UsingDictionary
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic["하나"] = "one";
            dic["둘"] = "two";
            dic["셋"] = "three";
            dic["넷"] = "four";
            dic["다섯"] = "five";

            WriteLine(dic["하나"]);
            WriteLine(dic["둘"]);
            WriteLine(dic["셋"]);
            WriteLine(dic["넷"]);
            WriteLine(dic["다섯"]);
        }
    }
}
