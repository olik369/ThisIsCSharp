using System;
using static System.Console;
using System.Collections;

namespace chp17.Enumerable
{
    class MyList : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;  //컬렉션의 현재 위치를 나타내는 변수여서 0이 아닌 -1임!

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
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

        //IEnumerator 멤버
        public object Current
        {
            get
            {
                return array[position];
            }
        }

        //IEnumerator 멤버
        public bool MoveNext()
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < array.Length);
        }

        //IEnumerator 멤버
        public void Reset()
        {
            position = -1;
        }

        //IEnumerable 멤버
        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i;

            foreach (int e in list)
                WriteLine(e);
        }
    }
}
