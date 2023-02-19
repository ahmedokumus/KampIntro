using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ahmed";
            int yas = 23;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Ahmed";
            kurs2.IzlenmeOrani = 56;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Hakan";
            kurs3.IzlenmeOrani = 75;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat";
            kurs4.IzlenmeOrani = 100;


            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[]
            {
                kurs1,
                kurs2,
                kurs3,
                kurs4
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }


            Console.WriteLine("Sayfa sonu");
        }

        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }
        }
    }
}