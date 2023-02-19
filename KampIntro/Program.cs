using System;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety(tip güvenliği)
            //Do not repeat yourself(kendini tekrarlama)
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.74;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Dolar Düştü");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Dolar Yükseldi");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}