using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ahmed Hakan
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Ahmed Hakan";
            musteri1.Soyadi = "Okumuş";
            musteri1.TcNo = "12345678910";

            //ENFE Machine
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "987654";
            musteri2.SirketAdi = "ENFE Machine";
            musteri2.VergiNo = "12345678910";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri(); //new bellekteki bir referans no'su
            Musteri musteri4 = new TuzelMusteri(); //Musteri hem gercek musterinin hem de tuzel musterinin referansını tutabiliyor

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
        }
    }
}
