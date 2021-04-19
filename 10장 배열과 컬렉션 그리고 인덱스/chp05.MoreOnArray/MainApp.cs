using System;
using static System.Console;

namespace chp05.MoreOnArray
{
    class MainApp
    {
        private static bool CheckPassed(int score)
        {
            return score >= 60;
        }
        private static void Print(int value)
        {
            Write($"{value} ");
        }
        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };

            foreach (int score in scores)
                Write($"{score} ");
            WriteLine();

            Array.Sort(scores);
            Array.ForEach<int>(scores, new Action<int>(Print));
            WriteLine();

            WriteLine($"Number of dimensions : {scores.Rank}");

            WriteLine($"Binary Search : 81 is at " + $"{Array.BinarySearch<int>(scores, 81)}");

            WriteLine($"Linear Search : 90 is at " + $"{Array.IndexOf(scores, 90)}");

            //TrueForAll메소드는 배열과 함께 조건을 검사하는 메소드를 매개변수로 받음
            WriteLine($"Everyone passed ? : " + $"{Array.TrueForAll<int>(scores, CheckPassed)}");
            //이건 람다식으로 쓴거여서 이해하기 쉽지않음
            int index = Array.FindIndex<int>(scores, (score) => score < 60);

            //60점 밑인 값을 60이상으로 바꿈
            scores[index] = 61;
            WriteLine($"Everyone passed ? : " + $"{Array.TrueForAll<int>(scores, CheckPassed)}");

            WriteLine("Old length of scores : " + $"{scores.GetLength(0)}");

            Array.Resize<int>(ref scores, 10);
            WriteLine($"New length of scores : {scores.Length}");

            Array.ForEach<int>(scores, new Action<int>(Print));
            WriteLine();

            Array.Clear(scores, 3, 7);
            Array.ForEach<int>(scores, new Action<int>(Print));
            WriteLine();

            int[] sliced = new int[3];
            Array.Copy(scores, 0, sliced, 0, 3);
            Array.ForEach<int>(sliced, new Action<int>(Print));
            WriteLine();
        }
    }
}
