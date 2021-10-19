using static System.Console;

namespace chp09.NamedParameter
{
    class MainApp
    {
        static void PrintProfile(string name, string phone)
        {
            WriteLine($"Name:{name}, Phone:{phone}");
        }
        
        static void Main(string[] args)
        {
            PrintProfile(name: "김동호", phone: "123-4567-8910");
            PrintProfile(phone: "010-0000-0000", name: "박지성");
            PrintProfile("박세리", "010-0021-1212");
            PrintProfile("박상현",phone:"010-1234-1243");
        }
    }
}
