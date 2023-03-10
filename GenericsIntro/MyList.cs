using System;
using System.ComponentModel;
using System.Linq;

namespace GenericsIntro
{
    public class MyList<T>
    {
        private T[] items;

        public MyList() //constructor
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
        
        public int Count
        {
            get { return items.Length; }
        }

    }
}
