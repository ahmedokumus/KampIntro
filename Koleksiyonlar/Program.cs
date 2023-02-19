using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[]
            //{
            //    "Ahmed",
            //    "Hakan",
            //    "Murat",
            //    "Halil"
            //};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string>()
            {
                "Aleyna",
                "Azra",
                "Sayra"
            };
            isimler2.Add("Egemen");
            Console.WriteLine(isimler2[3]);
        }
    }
}