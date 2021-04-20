using System;
using System.Collections;
using static System.Console;

namespace chp11.UsingQueue
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);
            que.Enqueue(6);

            while (que.Count > 0)
                WriteLine(que.Dequeue());
        }
    }
}
