using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //Naming convention
        //syntax
        public void Ekle(Urun urun) 
        {
            Console.WriteLine(urun.Adi + " Sepete eklendi");
            //
            //
            //
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine(urunAdi + " Sepete eklendi");
        }
    }
}
