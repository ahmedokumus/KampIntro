using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        int sonuc;
        public void Topla(int sayi1, int sayi2) 
        {
            sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
        }

        public void Carp(int sayi1, int sayi2)
        {
            sonuc = sayi1 * sayi2;
            Console.WriteLine(sonuc);
        }
    }
}
