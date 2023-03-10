using System;

namespace GameProject;

public class UserValidationManager : IUserValidationService
{
    public bool Validate(Gamer gamer)
    {
        if (gamer.Name == "Ahmed" && gamer.Surname == "Okumus" && gamer.BirthYear == 2000 &&
            gamer.IdentityNumber == 38839804216)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}