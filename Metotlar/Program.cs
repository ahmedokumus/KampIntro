using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun()
            {
                Id = 1,
                urunAdi = "Elma",
                fiyat = 13.4,
                aciklama = "Amasya elması"
            };

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.urunAdi = "Armut";
            urun2.fiyat = 12.5;
            urun2.aciklama = "Bal gibi";

            Urun[] urunler = new Urun[]
            {
                urun1, 
                urun2
            };

            //tape-safe(tip güvenli)
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.urunAdi + " | " + urun.fiyat + " | " + urun.aciklama);
                Console.WriteLine("------------------------------");
            }
            
            Console.WriteLine("\n------------METOTLAR------------");

            //instance(örnek)
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Karpuz",79.99,"Diyarbakır karpuzu");
            sepetManager.Ekle2("Elma",11.99,"Yeşil elma");
            sepetManager.Ekle2("Armut",15.99,"Mor armut");
        }
    }
}

//Do not repeat yourself(kendini tekrar etme) - DRY - Clean Code - Best Practice
//Tekrar tekrar kullanılabilirlik