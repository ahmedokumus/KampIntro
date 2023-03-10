using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            MyList<string> myList = new MyList<string>();
            myList.Add("İstanbul");
            myList.Add("Ankara");
            myList.Add("İzmir");
            Console.WriteLine(myList.Count);

            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Ahmed");
        }
    }
}