using System;
using static System.Console;

namespace chp09.PropertiesInInterface
{
    interface INamedValue
    {
        string Name
        {
            get;
            set;
        }
        string Value
        {
            get;
            set;
        }
    }
    class NamedValue : INamedValue
    {
        //인터페이스에서 선언한 프로퍼티도 반드시 구현해야함!!
        public string Name
        {
            get;
            set;
        }

        public string Value
        {
            get;
            set;
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            NamedValue name = new NamedValue()
            {
                Name = "이름",
                Value = "김동호"
            };

            NamedValue height = new NamedValue()
            {
                Name = "키",
                Value = "177Cm"
            };

            NamedValue weight = new NamedValue()
            {
                Name = "몸무게",
                Value = "90kg"
            };

            WriteLine($"{name.Name} : {name.Value}");
            WriteLine($"{height.Name} : {height.Value}");
            WriteLine($"{weight.Name} : {weight.Value}");
        }
    }
}
