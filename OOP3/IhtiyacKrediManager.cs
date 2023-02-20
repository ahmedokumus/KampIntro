using System;

namespace OOP3;

public class IhtiyacKrediManager : IKrediManager
{
    public void Hesapla()
    {
        //
        //

        Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
    }

    public void BiseyYap()
    {
        throw new System.NotImplementedException();
    }
}