using static System.Console;

namespace LocalFunction
{
    class MainApp
    {
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i)
            {
                if (arr[i] < 'A' || arr[i] > 'Z')
                    return arr[i];
                else
                    return (char)(arr[i] + 'a' - 'A');
            }

            return new string(arr);
        }

        static void Main(string[] args)
        {
            WriteLine(ToLowerString("Hello!"));
            WriteLine(ToLowerString("Good Morning."));
            WriteLine(ToLowerString("This is C#."));
        }
    }
}