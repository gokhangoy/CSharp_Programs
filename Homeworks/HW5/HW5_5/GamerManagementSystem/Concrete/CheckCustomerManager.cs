using GamerManagementSystem.Abstract;
using GamerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerManagementSystem.Concrete
{
    class CheckCustomerManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            //Checking Operation
            return true; 
        }
    }
}
