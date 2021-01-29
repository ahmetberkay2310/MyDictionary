using System;

namespace GameProjectt
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer { 
                Id = 1, 
                BirthYear = 2000,
                FirstName = "Berkay",
                LastName = "Karabulut",
                IdentityNumber = 12345
            });

            OrderManager orderManager = new OrderManager();
            orderManager.New(new Gamer  { Id = 1,
                BirthYear = 2000,
                FirstName = "Berkay",
                LastName = "Karabulut",
                IdentityNumber = 12345 
            });

            
        }
    }
}
