using System;
using static System.Console;
using System.Collections;

namespace 연습문제2
{
    class Matrix2D
    {
        public static int[,] MatrixDot(int[,]M1,int[,]M2)
        {
            int[,] Matrix = new int[2, 2];
            var a = M1[0, 0];
            var b = M1[0, 1];
            var c = M1[1, 0];
            var d = M1[1, 1];

            var e = M2[0, 0];
            var f = M2[0, 1];
            var g = M2[1, 0];
            var h = M2[1, 1];
            
            Matrix[0, 0] = a * e + b * g;
            Matrix[0, 1] = a * f + b * h;
            Matrix[1, 0] = c * e + d * g;
            Matrix[1, 1] = c * f + d * h;

            return Matrix;
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            int[,] matrixA = new int[2, 2] { { 3, 2 }, { 1, 4 } };
            int[,] matrixB = new int[2, 2] { { 9, 2 }, { 1, 7 } };
            int[,] result = new int[2, 2];
            result = Matrix2D.MatrixDot(matrixA, matrixB);

            for(int i = 0; i < result.GetLength(1); i++)
            {
                for(int j = 0; j < result.GetLength(0); j++)
                {
                    Write($"{result[i, j]} ");
                }
                WriteLine();
            }
        }
    }
}
