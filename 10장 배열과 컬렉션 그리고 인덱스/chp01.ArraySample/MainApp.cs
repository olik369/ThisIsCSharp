using System;
using static System.Console;

namespace chp01.ArraySample
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] Scores = new int[5];
            Scores[0] = 80;
            Scores[1] = 74;
            Scores[2] = 81;
            Scores[3] = 90;
            Scores[4] = 34;

            foreach (var score in Scores)
                WriteLine(score);

            int sum = 0;
            foreach (var score in Scores)
                sum += score;

            int average = sum / Scores.Length;

            WriteLine($"Average Score : {average}");
        }
    }
}
