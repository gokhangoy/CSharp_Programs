using GamerManagementSystem.Abstract;
using GamerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerManagementSystem.Concrete
{
    class GamerOperationManager : IGamerService
    {
        
        bool _flag = false;

        public GamerOperationManager(Gamer gamer, ICustomerCheckService checkGamer)
        {  
            _flag = checkGamer.CheckIfRealPerson((Gamer)gamer); ;
        }

        public void Delete(Gamer gamer) 
        {
            if (_flag)
            {
                Console.WriteLine("The gamer "+gamer.FirstName+" "+" has been succesfully deleted.");
            }
            else
            {
                Console.WriteLine("Deletion has failed.");
                
            }
        }

        public void Register(Gamer gamer)
        {
            if (_flag)
            {
                Console.WriteLine("The gamer " + gamer.FirstName + " " + " has been succesfully registered.");
            }

            else
            {
                Console.WriteLine("Register Operation has failed.");
            }

        }

        public void Update(Gamer gamer)
        {
            if (_flag)
            {
                Console.WriteLine("The gamer " + gamer.FirstName + " " + " has been succesfully updated.");
            }
            else
            {
                Console.WriteLine("Update Operation has failed.");
            }
        }
    }
}
