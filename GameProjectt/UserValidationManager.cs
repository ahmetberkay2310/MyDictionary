using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectt
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==2000 && 
                gamer.FirstName == "Berkay" && 
                gamer.LastName=="Karabulut" &&
                gamer.IdentityNumber==12345)
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
