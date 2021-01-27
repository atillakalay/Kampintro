using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStatteUserValidationManager());
            gamerManager.Add(new Gamer{Id = 1,BirthYear = 1999,FirstName = "Atilla",IdentityNumber = 123456,LastName = "Kalay"});
        }
    }
}
