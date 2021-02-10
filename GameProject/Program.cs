using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {

                Id = 1,
                BirthYear = 1989,
                FirstName = "GİZEM",
                LastName = "ÇINAR",
                IdentityNumber = 12345


            });


            Console.WriteLine("Hello World!");
        }
    }
}
