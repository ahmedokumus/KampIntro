using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(new Musteri()
            {
                Id = 1,
                Name = "Ahmed",
                Surname = "Okumus",
                IdentityNumber = "1234"
            });
        }
    }
}