using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 14.4;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 14.4;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 79.9;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "Şeftali";
            urun3.Fiyati = 12.5;
            urun3.Aciklama = "Bursa Şeftalisi";

            Urun[] urunler = new Urun[] {urun1, urun2, urun3 };

            //type-safe -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + " " + urun.Fiyati + "TL " + urun.Aciklama);
                Console.WriteLine("-------------------------------");
            }

            Console.WriteLine("---------------METOTLAR---------------");
            //instance - örnek
            //encapsulation - kapsülleme

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);

            Console.WriteLine("------------------------");

            sepetManager.Ekle2("Armut", "Yeşil armut", 23.4, 32);
            sepetManager.Ekle2("Elma", "Yeşil elma", 17, 10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12.5, 67);
        }
    }
}


//Dont repeat yourself - Kendini tekrar etme
//Clean code - Temiz kod yazma
//Best practice