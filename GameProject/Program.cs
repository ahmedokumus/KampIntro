using System;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer()
            {
                Id = 1,
                IdentityNumber = 38839804216,
                Name = "Ahmed",
                Surname = "Okumus",
                BirthYear = 2000
            });
        }
    }
}