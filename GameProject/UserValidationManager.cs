using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2000 &&
                gamer.FirstName == "Ahmed Hakan" &&
                gamer.LastName == "Okumus" &&
                gamer.IdentityNumber == 12345678910)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
