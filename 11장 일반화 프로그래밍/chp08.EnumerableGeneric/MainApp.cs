using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace chp08.EnumerableGeneric
{
    class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        //클래스 내부의 배열은 외부에서 수정할 수 없음!
        //그래서 프로퍼티를 이용해서 수정하려는 것임
        private T[] array;
        int position = -1;

        //기본 생성자 생성
        public MyList()
        {
            //임의의 데이터형의 크기 3인 배열 생성
            array = new T[3];
        }

        //indexer를 이용해서 객체를 배열처럼 사용할 수 있게 함!!
        public T this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }
        public int Length
        {
            get { return array.Length; }
        }

        //IEnumerable<T>의 메소드 2개중 1개를 구현함
        //IEnumerable은 하나만 구현하면 되지만 Generic한 이 인터페이스는 2개 구현해야됨
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        //이 밑에서부터는 IEnumerator에서 선언한 메소드의 구현부들임!!
        public T Current
        {
            get { return array[position]; }
        }

        object IEnumerator.Current
        {
            get { return array[position]; }
        }

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

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {

        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";

            foreach (string str in str_list)
                WriteLine(str);
            WriteLine();

            MyList<int> int_list = new MyList<int>();
            int_list[0] = 0;
            int_list[1] = 1;
            int_list[2] = 2;
            int_list[3] = 3;
            int_list[4] = 4;

            foreach (var no in int_list)
                WriteLine(no);
        }
    }
}
