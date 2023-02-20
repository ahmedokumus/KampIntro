using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            IKrediManager tasitKrediManager = new TasitKrediManager();

            IKrediManager konutKrediManager = new KonutKrediManager();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService>(){new SmsLoggerService(), new DatabaseLoggerService()});

            List<IKrediManager> krediler = new List<IKrediManager>()
            {
                konutKrediManager,
                ihtiyacKrediManager
            };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            //S(O)LID => sisteme yeni kodlar eklendiğinde mevcut kodlar bozulmaz.s
        }
    }
}