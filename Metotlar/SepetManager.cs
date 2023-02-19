using System;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.urunAdi);
            //Ekleme işlerinin yapılacağı kodlar yazılır
        }

        public void Ekle2(string urunAdi, double fiyat, string aciklama)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
