using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ahmed Okumus
            GercekMusteri musteri1 = new GercekMusteri()
            {
                Id = 1,
                Adi = "Ahmed",
                Soyadi = "Okumus",
                TcNo = "12345678910"
            };

            TuzelMusteri musteri2 = new TuzelMusteri()
            {
                Id = 2,
                SirketAdi = "KodlamaIO",
                musteriNo = "54321",
                VergiNo = "1234567890"
            };

            //Gerçek Müşteri - Tüzel Müşteri
            //SO(L)ID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);


        }
    }
}