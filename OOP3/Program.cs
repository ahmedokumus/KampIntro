using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface onu implamente eden class ın referansını tutabilir.

            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); //instance oluşturma böyle de yapılabilir
            IKrediManager tasitKrediManager = new TasitKrediManager(); //instance oluşturma böyle de yapılabilir
            IKrediManager konutKrediManager = new KonutKrediManager(); //instance oluşturma böyle de yapılabilir

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), //instance oluşturma böyle de yapılabilir
                new List<ILoggerService> //1 den fazla loglama için liste oluşturma
                { 
                    new DatabaseLoggerService(), //instance oluşturma böyle de yapılabilir
                    new SmsLoggerService() //instance oluşturma böyle de yapılabilir
                });

            //1 den fazla kredinin hesaplanması için liste oluşturma
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
