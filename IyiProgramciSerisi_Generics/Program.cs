using System;
using System.Collections.Generic;

namespace IyiProgramciSerisi_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler1 = new List<string>();
            sehirler1.Add("Ankara");
            Console.WriteLine(sehirler1.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("İstanbul");
            Console.WriteLine(sehirler2.Count);
        }
    }

    class MyList<T> //Generic class
    {
        private T[] _array;
        private T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
            _count = _array.Length;
        }

        private int _count;
        public int Count
        {
            get { return _count; }
        }

    }
}