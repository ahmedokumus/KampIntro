using System;

namespace ClassMetotDemo;

public class MusteriManager : IMusteriService
{
    public void Add(Musteri musteri)
    {
        Console.WriteLine("Musteri eklendi");
    }

    public void List(Musteri musteri)
    {
        Console.WriteLine("Musteri listelendi");
    }

    public void Delete(Musteri musteri)
    {
        Console.WriteLine("Musteri silindi");
    }
}