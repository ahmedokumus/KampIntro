using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type safety - tip güvenliği
            // Do not repeat yourself - Kendini tekrarlama

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;
            double DolarDun = 7.35;
            double DolarBugun = 7.45;

            if (DolarDun>DolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (DolarDun<DolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
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
