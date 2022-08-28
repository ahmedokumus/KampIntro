using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ahmed";
            int yas = 22;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Ahmed";
            kurs1.Izlendimi = true;
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.Egitmen = "Hakan";
            kurs2.Izlendimi = false;
            kurs2.IzlenmeOrani = 54;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Egemen";
            kurs3.Izlendimi = true;
            kurs3.IzlenmeOrani = 75;

            //Console.WriteLine(kurs3.KursAdi + " - " + kurs3.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.Egitmen);
                Console.WriteLine(kurs.Izlendimi);
                Console.WriteLine(kurs.IzlenmeOrani);
                Console.WriteLine(" ");
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public bool Izlendimi { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
