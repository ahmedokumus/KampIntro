using System.Collections.Generic;

namespace OOP3;

public class BasvuruManager
{
    //Method injection
    public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)
    {
        //Başvuru bilgilerini değerlendirme
        //
        //

        krediManager.Hesapla();
        foreach (var log in loggerService)
        {
            log.Log();
        }
    }

    public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
    {
        foreach (var kredi in krediler)
        {
            kredi.Hesapla();
        }
    }
}