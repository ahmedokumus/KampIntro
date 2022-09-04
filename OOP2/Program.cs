using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ahmed Hakan //Müşteri1
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Ahmed Hakan";
            musteri1.Soyadi = "Okumuş";
            musteri1.TcNo = "12345678910";

            //ENFE Machine //Müşteri2
            TuzelMusteri musteri2 = new TuzelMusteri
            {
                Id = 2, 
                MusteriNo = "987654", 
                SirketAdi = "ENFE Machine", 
                VergiNo = "12345678910" 
            };

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri(); //new bellekteki bir referans no'su
            Musteri musteri4 = new TuzelMusteri(); //Musteri class ı hem gercek musterinin hem de tuzel musterinin referansını tutabiliyor

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);


        }
    }
}
