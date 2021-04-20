using System;
using static System.Console;
using System.Collections;

namespace chp15.Indexer
{
    class MyList
    {
        private int[] array;

        public MyList()
        {
            array = new int[3];
        }

        //마치 this를 통해 프로퍼티처럼 get,set을 구현하고 index를 통해 배열처럼 구현할 수 있음
        public int this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            for(int i = 0; i < 5; i++)
            {
                list[i] = i;
            }
            for(int i = 0; i < list.Length; i++)
            {
                WriteLine(list[i]);
            }
        }
    }
}
