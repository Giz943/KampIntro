using System;
namespace GameProject
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1989 && gamer.FirstName == "GİZEM"
               && gamer.LastName == "ÇINAR" && gamer.IdentityNumber ==12345)
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
